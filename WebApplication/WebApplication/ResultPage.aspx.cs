using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication
{
    public partial class ResultPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client service = new ServiceReference1.Service1Client();

            decimal operand1;
            decimal operand2;
            string operation = Request.QueryString["op"];
            string result;

            if (!Decimal.TryParse(Request.QueryString["o1"], out operand1)) operand1 = 0.0M;
            if (!Decimal.TryParse(Request.QueryString["o2"], out operand2)) operand2 = 0.0M;

            if (operation == "/" && operand2 == 0)
            {
                result = "NaN";
            }
            else
            {
                result = service.Calculate(operand1, operand2, operation == "plus" ? "+" : operation).ToString();
            }
            ResultLabel.Text = String.Format("{0} {1} {2} = {3}", operand1, operation == "plus" ? "+" : operation, operand2, result);
        }
    }
}