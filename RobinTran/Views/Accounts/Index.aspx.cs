using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Telerik.Web.UI;

namespace RobinTran.Views.Accounts
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RadGridAccountList_ItemDataBound(object sender, Telerik.Web.UI.GridItemEventArgs e)
        {
            Helpers.PageHelper pageHelper = new Helpers.PageHelper();
            pageHelper.SetSequenceNumberColumn(RadGridAccountList, e, "lblSequenceNumber");
        }
    }
}