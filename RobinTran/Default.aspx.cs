using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Telerik.Web.UI;

namespace RobinTran
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void showDialog_Click(object sender, EventArgs e)
        {
            RadWindow newWindow = new RadWindow();
            newWindow.NavigateUrl = "~/Views/Test.aspx";
            newWindow.VisibleOnPageLoad = true;
            newWindow.Modal = true;
            newWindow.VisibleTitlebar = false;
            newWindow.VisibleStatusbar = false;
            RadWindowManager1.Windows.Add(newWindow); 
        }
    }
}