using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebControls
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            #region Boolean operations

            

            
            bool ssd = SSD.Checked;
            bool ram = SixteenGB.Checked;
            bool duel = DualMonitor.Checked;

            Message.Text = "You selected ";
            //use boolean checks to confirm if statement is true or not
            Message.Text += ssd ? "SSD Drive" : "";
            Message.Text += ram ? "16GB RAM" : "";
            Message.Text += duel ? "Dual Monitor" : "";
            #endregion

            foreach (ListItem li in CheckBoxList1.Items)
            {
                if (li.Selected)
                {
                    Message.Text += li.Value.ToString();
                }
            }

            #region OutputPrep

            

           
            Message.Text += "<br/>The customer is ";
            Message.Text += Male.Checked ? "Male" : "Female";
            Message.Text += "<br/>Your age group is ";

            Message.Text += RadioButtonList1.SelectedValue.ToString() + ". ";
            Message.Text += "You selected Item ";
            Message.Text += DropDownList1.SelectedValue.ToString();

            #endregion






        }
    }
}