using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RobinTran.Models;
using System.Resources;

namespace RobinTran.MasterPage
{
    public partial class _DefaultMasterPage : System.Web.UI.MasterPage
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

            btSignIn.Text = rm.GetString("btSignIn");
        }

        protected void btSignIn_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            Helpers.Account helper = new Helpers.Account();
            password = helper.MD5Encrypt(password);
            RobinTranEntities db = new RobinTranEntities();
            var account = db.Accounts.SingleOrDefault(acc => acc.Email.Equals(email) && password.Equals(password));
            if (account != null)
            {
                Session["AccountID"] = account.AccountID;
                Response.Redirect("~/Admin/Account");
            }
            else
            {
                Response.Redirect("~/");
            }
        }
    }
}