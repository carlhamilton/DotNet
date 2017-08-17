using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_011
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void OkButton_Click(object sender, EventArgs e)
        {
            if (firstTextBox.Text == secondTextBox.Text)
            {
                resultLabel.Text = "Yes! They're equivalent!";
            }
            else
            {
                resultLabel.Text = "No! They're not equivalent!";
            }
        }

        protected void okButton2_Click(object sender, EventArgs e)
        {
            if (PizzaButton.Checked)
            {
                resultLabel2.Text = "You must be from Chicago or love carbs!";
            }
            else if (ChineseButton.Checked)
            {
                resultLabel2.Text = "You must love chinese food I bet it was a curry!";
            }
            else if (ChickenNVeg.Checked)
            {
                resultLabel2.Text = "You must be very healthy, I bet you go to the gym too!";
            }
            else
            {
                resultLabel2.Text = "Please select one of the options listed";
            }
        }
    }
}