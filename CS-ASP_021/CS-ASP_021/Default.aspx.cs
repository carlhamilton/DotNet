using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_021
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            //We use an array to assign multiple names to the location of the array
            string[] values = new string[5] { "Bob", "Steve", "Chuck", "Brian", "Andy" };
            ViewState.Add("MyValues", values);
            resultLabel.Text = "Values added...";


        }

        protected void retrieveButton_Click(object sender, EventArgs e)
        {
            //since our array holds names in value states 0-4 we now assign these values back into a textBox.
            string[] values = (string[])ViewState["MyValues"];
            TextBox1.Text = values[0];
            TextBox2.Text = values[1];
            TextBox3.Text = values[2];
            TextBox4.Text = values[3];
            TextBox5.Text = values[4];
            //just displays that the value was retrieved
            resultLabel.Text = "Values retrieved...";
        }
    }
}