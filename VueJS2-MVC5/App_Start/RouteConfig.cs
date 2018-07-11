using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace VueJS2_MVC5
{
  public class RouteConfig
  {
    public static void RegisterRoutes(RouteCollection routes)
    {

      routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

      routes.MapMvcAttributeRoutes();

      routes.MapRoute(
          name: "default",
          url: "{controller}/{action}/{id}",
          defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },

          // Set a constraint to only use this for routes identified as server-side routes
          constraints: new
          {
            serverRoute = new ServerRouteConstraint(url =>
            {
              return url.PathAndQuery.StartsWith("/api",
                StringComparison.InvariantCultureIgnoreCase);
            })
          });

      // This is a catch-all for when no other routes matched. Let the vuejs router take care of it
      routes.MapRoute(
          name: "vuejs",
                url: "{*url}",
                defaults: new { controller = "Home", action = "Index" }
            );
    }
  }

  public class ServerRouteConstraint : IRouteConstraint
  {
    private readonly Func<Uri, bool> _predicate;

    public ServerRouteConstraint(Func<Uri, bool> predicate)
    {
      this._predicate = predicate;
    }

    public bool Match(HttpContextBase httpContext, Route route, string parameterName,
        RouteValueDictionary values, RouteDirection routeDirection)
    {
      return this._predicate(httpContext.Request.Url);
    }
  }
}
