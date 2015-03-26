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

namespace RobinTran.Helpers
{
    public class PageHelper
    {
        public PageHelper() { }
        public void AlertMessage(System.Web.UI.Page _page,string _message)
        {
            _page.ClientScript.RegisterStartupScript(_page.GetType(), "Script", "<script>" +
                    "alert('Thông tin đăng nhập không đúng!\\nVui lòng kiểm tra lại.');"
                    + "</script>");
        }
        public ResourceManager SetCulture(string _language)
        {
            CultureInfo infor = new CultureInfo(_language);
            Thread.CurrentThread.CurrentCulture = infor;
            Thread.CurrentThread.CurrentUICulture = infor;

            ResourceManager rm = new ResourceManager("Resources.RobinResource", Assembly.Load("App_GlobalResources"));
            return rm;
        }
    }
}