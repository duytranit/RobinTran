using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RobinTran.Partials
{
    public partial class _RightComponents : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Session["Language"] != null)&&(Session["Language"].ToString().Equals("en-US")))
                imgButtonEN.Enabled = false;
            else
                imgButtonVN.Enabled = false;
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