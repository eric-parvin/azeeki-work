using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ValidateMyInsurance
{
    public partial class ThankYou : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ////Policy Type Email Generated
            //var insType = Request.QueryString[0].ToString();

            //switch (insType)
            //{
            //    case "h":
            //        lblMessage.Text = "Home Insurance";
            //        break;
            //    case "f":
            //        lblMessage.Text = "Flood Insurance";
            //        break;
            //    case "a":
            //        lblMessage.Text = "Auto Insurance";
            //        break;
            //    case "c":
            //        lblMessage.Text = "Condo Insurance";
            //        break;
            //    case "co":
            //        lblMessage.Text = "Commerical Insurance";
            //        break;
            //    case "b":
            //        lblMessage.Text = "Business Insurance";
            //        break;
            //    default:
            //        lblMessage.Text = "Home Insurance";
            //        break;
            //}
        }
    }
}