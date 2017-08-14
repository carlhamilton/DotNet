using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

/// <summary>
/// Simple App to ask a user to select which item they use to take notes
/// the objective is then to state to selection & display corresponding picture by Carl Hamilton 13.08.2017.
/// </summary>

namespace noteTakingConditional
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            if(pencilCheck.Checked)
            {
                resultLabel.Text = "You selected Pencil";
                imageSet.ImageUrl = "pencil.png";
                
            }
            else if(penCheck.Checked)
            {
                resultLabel.Text = "You selected Pen";
                imageSet.ImageUrl = "pen.png";
            }
            else if(phoneCheck.Checked)
            {
                resultLabel.Text = "You selected Phone";
                imageSet.ImageUrl = "phone.png";
            }
            else if(tabletCheck.Checked)
            {
                resultLabel.Text = "You selected Tablet";
                imageSet.ImageUrl = "tablet.png";
            }
        }
      

        protected void pencilCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void penCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void phoneCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void tabletCheck_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}