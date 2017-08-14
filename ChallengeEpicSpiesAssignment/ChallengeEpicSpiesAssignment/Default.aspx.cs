using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeEpicSpiesAssignment
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                previousAssignment.SelectedDate = DateTime.Now.Date;
                newAssignment.SelectedDate = DateTime.Now.Date.AddDays(14);
                newAssignmentEnd.SelectedDate = DateTime.Now.Date.AddDays(21);
            }

        }

        protected void spyTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void assignmentTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void assignButton_Click(object sender, EventArgs e)
        {
            //We first work out the charging rate
            TimeSpan totalDurationOfAssignment = newAssignmentEnd.SelectedDate.Subtract(newAssignment.SelectedDate);//take from expected end date to start date and subtract to work out the length of the contract
            //We take a new variable called totalCost and multiply total days of assignment by our rate per day.

            double totalCost = totalDurationOfAssignment.TotalDays * 500.00;

            //This conditional statement added as if we complete the assignment the same day the application would not assign payment without this expression as even though it is technically one day the calendar will say 0 days.
            if(totalDurationOfAssignment.TotalDays == 0)
            {
                totalCost = 500;
            }

            //If our task exceeds 21 days we pay a £1000 bonus
            if(totalDurationOfAssignment.TotalDays > 21)
            {
                //we use the += to add £1000 to the totalCost value.
                totalCost += 1000.00;
            }
            //We assign the totals and written assignment to our output seperated by , to indicate 0-1-2 (array assignment of options)
            resultLabel.Text = String.Format("Assignment of {0} to assignment {1} is authorised. Budget total: {2:C}",
            spyTextBox.Text,
            assignmentTextBox.Text,
            totalCost);
            //We use this to workout the time between assignments so subtract the difference in dates from the old to the new and out put error if not within range.
            TimeSpan timeBetweenAssignments = newAssignment.SelectedDate.Subtract(previousAssignment.SelectedDate);
            if(timeBetweenAssignments.TotalDays < 14)
            {
                //error is displayed if timebetween assignments is less than two weeks we were assigned by the union.
                resultLabel.Text = "Error: Must allow at least two weeks between " + "previous assignment and new assignment.";

                //We set this to state it needs to be 14 days since the last assignment
                DateTime earliestNewAssignmentDate = previousAssignment.SelectedDate.AddDays(14);

                newAssignment.SelectedDate = earliestNewAssignmentDate;
                newAssignment.VisibleDate = earliestNewAssignmentDate;
                    
            }//Added to ensure a deposit of 30% is requested before accepting a job with a value over £10K
            if(totalCost >= 10000 )
            {
                double deposit;

                deposit = (totalCost / 100) * 30;

                clauseLabel.Text = String.Format("Please collect a deposit of {0:C}",
                    deposit);
            }
            if(totalCost <10000)
            {
                clauseLabel.Text = String.Format("");
            }


        }
    }
}