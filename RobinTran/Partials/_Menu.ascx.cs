using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;
using System.Resources;
using System.Reflection;
using System.Threading;

namespace RobinTran.MasterPage
{
    public partial class _Menu : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Session["Language"] != null) && (Session["Language"].ToString().Equals("en-US")))
            {
                CultureInfo infor = new CultureInfo("en-US");
                SetCulture(infor);
            }
            else 
            {
                CultureInfo infor = new CultureInfo("vi-VN");
                SetCulture(infor);
            }
        }

        private void SetCulture(CultureInfo _infor)
        {
            Thread.CurrentThread.CurrentCulture = _infor;
            Thread.CurrentThread.CurrentUICulture = _infor;

            ResourceManager rm = new ResourceManager("Resources.RobinResource", Assembly.Load("App_GlobalResources"));
            btHome.Text = rm.GetString("mnHome");
            btSignIn.Text = rm.GetString("mnSignIn");
        }
    }
}