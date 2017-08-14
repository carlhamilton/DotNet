using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_009
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            int i = 1;
            int j = 2;
            int result = 1 + j; //Addition

            resultLabel.Text = result.ToString();

            int firstNumber = 20000000;
            int secondNumber = 20000000;
            int resultNumber;
            //Purposeful overflow testing int and using checked to show this.
            checked
            {
                resultNumber = firstNumber * secondNumber;

            }
            
        }
    }
}