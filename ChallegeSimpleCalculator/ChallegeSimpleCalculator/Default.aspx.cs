using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
/// <summary>
/// Simple Web Calculator by Carl Hamilton
/// V1.0 
/// </summary>

namespace ChallegeSimpleCalculator
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Serioes of functions depicting addition, subtraction, multiplication and division.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button2_Click(object sender, EventArgs e)
        {
            int firstNumnber = int.Parse(firstNumberTextBox.Text);
            int secondNumber = int.Parse(secondNumberTextBox.Text);

            int arithmaticCalculation = firstNumnber - secondNumber;

            string result = "Your answer is: " + arithmaticCalculation;

            ResultLabel.Text = result;
        }

        protected void AdditionBox_Click(object sender, EventArgs e)
        {
            int firstNumnber = int.Parse(firstNumberTextBox.Text);
            int secondNumber = int.Parse(secondNumberTextBox.Text);

           int arithmaticCalculation = firstNumnber + secondNumber;

            string result = "Your answer is: " + arithmaticCalculation;

            ResultLabel.Text = result;

        }

        protected void MultiplicatonBox_Click(object sender, EventArgs e)
        {
            int firstNumnber = int.Parse(firstNumberTextBox.Text);
            int secondNumber = int.Parse(secondNumberTextBox.Text);

            int arithmaticCalculation = firstNumnber * secondNumber;

            string result = "Your answer is: " + arithmaticCalculation;

            ResultLabel.Text = result;
        }

        protected void DivisionBox_Click(object sender, EventArgs e)
        {
            double firstNumnber = double.Parse(firstNumberTextBox.Text);
            double secondNumber = double.Parse(secondNumberTextBox.Text);

            double arithmaticCalculation = firstNumnber / secondNumber;

            string result = "Your answer is: " + arithmaticCalculation;

            ResultLabel.Text = result;

        }
    }
}