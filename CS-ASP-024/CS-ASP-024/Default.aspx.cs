using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_024
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            // x is accessible to to this method and the if statement
            int x = 1;

            if(x ==1)
            {
                x = 2;
                int y = 3;
            }

            //we can use x as it was defined but if we used y it would not be available.
            string result = x.ToString();
        
        }
    }
}