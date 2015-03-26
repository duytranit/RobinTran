using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Resources;

namespace RobinTran.Partials
{
    public partial class _RightComponents : System.Web.UI.UserControl
    {
        private Helpers.PageHelper _pageHelper = new Helpers.PageHelper();
        protected ResourceManager rm;
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Session["Language"] != null) && (Session["Language"].ToString().Equals("en-US")))
            {
                imgButtonEN.Enabled = false;
                rm = _pageHelper.SetCulture("en-US");
            }

            else 
            {
                imgButtonVN.Enabled = false;
                rm = _pageHelper.SetCulture("vi-VN");
            }
        }

        protected void imgButtonVN_Click(object sender, ImageClickEventArgs e)
        {
            Session["Language"] = "vi-VN";
            imgButtonVN.Enabled = false;
            imgButtonEN.Enabled = true;
            Response.Redirect(Request.RawUrl);
        }

        protected void imgButtonEN_Click(object sender, ImageClickEventArgs e)
        {
            Session["Language"] = "en-US";
            imgButtonEN.Enabled = false;
            imgButtonVN.Enabled = true;
            Response.Redirect(Request.RawUrl);
        }
    }
}