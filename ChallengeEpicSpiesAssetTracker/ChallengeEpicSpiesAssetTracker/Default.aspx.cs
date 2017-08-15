using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeEpicSpiesAssetTracker
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)//Condition to set to prevent contstant re-initialising of varibles.
            {
                string[] assets = new string[0];
                int[] elections = new int[0];
                int[] aosp = new int[0];

                ViewState.Add("Assets", assets);
                ViewState.Add("Elections", elections);
                ViewState.Add("AOSP", aosp);


            }

        }

        protected void assetTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void electionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void aospTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void assetButton_Click(object sender, EventArgs e)
        {
            string[] assets = (string[])ViewState["Assets"];
            int[] elections = (int[])ViewState["Elections"];
            int[] aosp = (int[])ViewState["AOSP"];

            int newLength = assets.Length + 1;

            //We re-size the arrays with an array reference and specify the new lenght of the array by adding 1 to the previous array length
            Array.Resize(ref assets, newLength);
            Array.Resize(ref elections, newLength);
            Array.Resize(ref aosp, newLength);

            int newIndex = assets.GetUpperBound(0);

            assets[newIndex] = assetTextBox.Text;
            elections[newIndex] = int.Parse(electionTextBox.Text);
            aosp[newIndex] = int.Parse(aospTextBox.Text);

            ViewState["Assets"] = assets;
            ViewState["Elections"] = elections;
            ViewState["AOSP"] = aosp;
            //N2 is used to display 2 decimal places
            resultLabel.Text = String.Format("Total Elections Rigged: {0}<br />Average Acts of Subterfuge per Asset: {1:N2}<br />(Last Asset you Added: {2})",
                elections.Sum(),//We use this to add all the integers stored in the election array
                aosp.Average(),//discover the average
                assets[newIndex]);

            //We then clear the text boxes so the next entry can be added.
            assetTextBox.Text = "";
            electionTextBox.Text = "";
            aospTextBox.Text = "";

        }
    }
}