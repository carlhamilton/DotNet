using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_014
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            //DateTime myValue = DateTime.Now;

            //  DateTime myValue = DateTime.Parse("12/7/1969");

            DateTime myValue = new DateTime(1069, 12, 7, 6, 30, 0);

           resultLabel.Text = myValue.ToLongDateString();
           // resultLabel.Text = myValue.ToLongTimeString();
          //  resultLabel.Text = myValue.ToShortDateString();
           // resultLabel.Text = myValue.ToShortTimeString();
        }
    }
}