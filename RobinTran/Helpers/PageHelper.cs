using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
    }
}