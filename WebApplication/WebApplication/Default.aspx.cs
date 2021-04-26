using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void CalculateButton_Click(object sender, EventArgs e)
        {
            Response.Redirect(String.Format("ResultPage.aspx?o1={0}&o2={1}&op={2}", OperandField1.Text, OperandField2.Text, OperationSelect.SelectedValue));
        }
    }
}