using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace Tornado14Lab.StatusPublisherWeb
{
  public class Global : System.Web.HttpApplication
  {

    protected void Application_Start(object sender, EventArgs e)
    {
      RegisterRoutes(RouteTable.Routes);
    }

    void RegisterRoutes(RouteCollection routes)
    {
      routes.Ignore("{*allcss}", new { allcss = @".*\.css(/.*)?" });
      routes.Ignore("{*alljpg}", new { alljpg = @".*\.jpg(/.*)?" });
      routes.Ignore("{*alljs}", new { alljs = @".*\.js(/.*)?" });
      routes.MapPageRoute("",
          "", "~/index.aspx");
      routes.MapPageRoute("status",
          "status/{sprint}/{project}", "~/Kanban.aspx");
    }

    protected void Session_Start(object sender, EventArgs e)
    {

    }

    protected void Application_BeginRequest(object sender, EventArgs e)
    {

    }

    protected void Application_AuthenticateRequest(object sender, EventArgs e)
    {

    }

    protected void Application_Error(object sender, EventArgs e)
    {

    }

    protected void Session_End(object sender, EventArgs e)
    {

    }

    protected void Application_End(object sender, EventArgs e)
    {

    }
  }
}