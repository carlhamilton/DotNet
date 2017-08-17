using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_019
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submitButton_Click(object sender, EventArgs e)
        {
            int ss = int.Parse(ssTextBox.Text);
            int phone = int.Parse(phoneTextBox.Text);

            string result = string.Format("Thank you, {0}, for your business." +
                "<br />Your Social Security number is: {1:000-00-0000}" +
                "<br />Phone: {2: (000) 000-0000}" +
                "<br />Loan Date: {3:ddd -- d, M, yy}", 
                nameTextBox.Text, 
                ss,
                phone,
                loanDateCalendar.SelectedDate);
            resultLabel.Text = result;
        }
    }
}