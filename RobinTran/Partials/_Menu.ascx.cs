using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Resources;

namespace RobinTran.MasterPage
{
    public partial class _Menu : System.Web.UI.UserControl
    {
        private Helpers.PageHelper _pageHelper = new Helpers.PageHelper();
        protected ResourceManager rm;
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Session["Language"] != null) && (Session["Language"].ToString().Equals("en-US")))
            {
                rm = _pageHelper.SetCulture("en-US");
            }
            else 
            {
                rm = _pageHelper.SetCulture("vi-VN");
            }
            btSignIn.Text = rm.GetString("mnSignIn");
        }
    }
}