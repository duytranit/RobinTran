using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RobinTran.Models;

namespace RobinTran.Views.Accounts
{
    public partial class Update : System.Web.UI.Page
    {
        private RobinTranEntities db = new RobinTranEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = Convert.ToInt32(Session["AccountID"]);
                var account = db.Accounts.SingleOrDefault(acc => acc.AccountID == id);
                txtEmail.Text = account.Email;
            }
        }

        protected void btUpdate_Click(object sender, EventArgs e)
        {
            if (!txtPassword.Text.Equals(txtConfirmation.Text))
            {
                Helpers.PageHelper helper = new Helpers.PageHelper();
                helper.AlertMessage(this,"Xác nhận mật khẩu không đúng!");
            }
        }
    }
}