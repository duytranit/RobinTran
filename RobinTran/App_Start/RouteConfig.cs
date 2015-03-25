using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Routing;
using Microsoft.AspNet.FriendlyUrls;

namespace RobinTran
{
    public static class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.EnableFriendlyUrls();
            routes.MapPageRoute("DefaultPage", "", "~/Default.aspx");

            routes.MapPageRoute("AdminAccountUpdating", "Admin/Account", "~/Views/Accounts/Update.aspx");
        }
    }
}
