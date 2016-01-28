using System;
using System.Linq;
using System.Web.Mvc;
using System.Web.Routing;

namespace LigaPetiWeb.App_Start
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Client", action = "Index", id = UrlParameter.Optional });

            //routes.MapRoute("redirect all other requests", "{*url}",
            //    new
            //{
            //    controller = "UI",
            //    action = "Index"
            //}).DataTokens = new RouteValueDictionary(new { area = LigaPetiClientAreaRegistration.c_areaName });
        }
    }
}