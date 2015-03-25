using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Telerik.Web.UI;
using System.Globalization;
using System.Threading;
using System.Resources;
using System.Reflection;

namespace RobinTran
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CultureInfo infor = new CultureInfo("en-US");
            SetCulture(infor);            
        }
        private void SetCulture(CultureInfo _infor)
        {
            Thread.CurrentThread.CurrentCulture = _infor;
            Thread.CurrentThread.CurrentUICulture = _infor;

            ResourceManager rm = new ResourceManager("Resources.RobinResource", Assembly.Load("App_GlobalResources"));
            string value = rm.GetString("test");
            lblTest.Text = value;
        }

        protected void btVietname_Click(object sender, EventArgs e)
        {
            CultureInfo infor = new CultureInfo("vi-VN");
            SetCulture(infor);
        }
    }
}