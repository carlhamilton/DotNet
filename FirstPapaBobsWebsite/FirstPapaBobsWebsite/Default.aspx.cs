using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

/// <summary>
/// 1.0 version of Papa Bob's amazing pizza parlour.
/// </summary>

namespace FirstPapaBobsWebsite
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void BabyBobRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void papaBobRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void ThinCrustRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void DeepDishRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void PepperoniCheckButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void OnionsCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void GreenPeppersCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void RedPeppersCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void AnchoviesCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void purchaseButton_Click(object sender, EventArgs e)
        {
            double total;

            if(BabyBobRadioButton.Checked)
            {
                total = 10.0;
            }
            else if(MamaBobSizeButton.Checked)
            {
                total = 13.0;
            }
            else
            {
                total = 16.0;
            }

            if(DeepDishRadioButton.Checked)
            {
                total += 1.0;
            }
            // uses conditions to check if the button is checked if it is then add the extra cost for the choices made
            total = (PepperoniCheckButton.Checked) ? total + 1.5 : total;
            total = (OnionsCheckBox.Checked) ? total + 0.75 : total;
            total = (GreenPeppersCheckBox.Checked) ? total + 0.5 : total;
            total = (RedPeppersCheckBox.Checked) ? total + 0.75 : total;

            if (AnchoviesCheckBox.Checked) total += 2.0;

            if ((PepperoniCheckButton.Checked &&
                GreenPeppersCheckBox.Checked &&
                AnchoviesCheckBox.Checked) ||
                (PepperoniCheckButton.Checked &&
                RedPeppersCheckBox.Checked &&
                OnionsCheckBox.Checked))
            {
                total -= 2.0;
            }

            //takes the final total and takes it from a number to a string so it can be output into the label.
            totalCost.Text = "£" + total.ToString();

        }
    }
}