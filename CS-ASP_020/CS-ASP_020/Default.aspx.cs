using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_020
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                //we call a viewstate and add the value that we choose in the addButton function
                ViewState.Add("MyValue", "");
            }
        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            //we add the valueTextBox details into the resultLabel to sow the enter
            string value = ViewState["MyValue"].ToString();
            value += valueTextBox.Text + " ";
            ViewState["MyValue"] = value;
            resultLabel.Text = value;

            valueTextBox.Text = "";
        }
    }
}