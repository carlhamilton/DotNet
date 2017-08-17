using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_012
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            resultLabel.Text = (oldCheckBox.Checked) ?
               "I'm teaching an old dog new tricks!" :
               "Young whippersnapper! Get off my lawn!";

        }

        protected void oldCheckBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            resultLabel.Text = (oldCheckBox.Checked) ?
               "I'm teaching an old dog new tricks!" :
               "Young whippersnapper! Get off my lawn!";

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            //Here we use the Tenerary ? operator in place of if/else statement

            resultLabel.Text = (firstTextBox.Text == secondTextBox.Text) ? "Yes" : "No";
            scoreResult.Text = (firstTextBox.Text == secondTextBox.Text) ?
                "100" : "50";
        }

        protected void oldCheckBox_CheckedChanged(object sender, EventArgs e)
        {
           
        }
    }
}