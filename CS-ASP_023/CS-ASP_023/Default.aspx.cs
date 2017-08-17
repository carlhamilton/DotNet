using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_023
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                double[] hours = new double[0];
                ViewState.Add("Hours", hours);
            }

        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            double[] hours = (double[])ViewState["Hours"];
            //takes hours variable into a resized array with the ref tag
            //this makes it possible to change the size without copying back to original variable (a new variable is created).
            Array.Resize(ref hours, hours.Length + 1);
            int newestItem = hours.GetUpperBound(0);

            hours[newestItem] = double.Parse(hoursTextBox.Text);

            ViewState["Hours"] = hours;
            resultLabel.Text = String.Format(
                //We assign a string as an array then use hours to get different available hours methods.
                "Total Hours: {0}<br />" +
                "Most Hours: {1}<br />" +
                "Least Hours: {2}<br />" +
                "Average Hours: {3:N2}",
                hours.Sum(),
                hours.Max(),
                hours.Min(),
                hours.Average()
                );
        }
    }
}