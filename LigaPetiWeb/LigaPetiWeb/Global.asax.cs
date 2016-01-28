using System;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Dispatcher;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using AreasHelp.AreaSelection;
using LigaPetiDbModel.DataContext.LigaPeti;
using LigaPetiDbModel.Initializers;
using LigaPetiWeb.App_Start;
using LigaPetiWeb.Infrastructure.IoC;

namespace LigaPetiWeb
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            // base 
            //AreaRegistration.RegisterAllAreas();
            //GlobalConfiguration.Configure(WebApiConfig.Register);
            //FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            //RouteConfig.RegisterRoutes(RouteTable.Routes);
            //BundleConfig.RegisterBundles(BundleTable.Bundles);

            // new
            System.Data.Entity.Database.SetInitializer((System.Data.Entity.IDatabaseInitializer<LigaPetiDb>)new LigaPetiDbInitializer());

            // DOne in advance
            GlobalConfiguration.Configuration.Services.Replace(typeof(IHttpControllerSelector), new AreaHttpControllerSelector(GlobalConfiguration.Configuration));

            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            NinjectResolver resolver = (NinjectResolver)GlobalConfiguration.Configuration.DependencyResolver;
            resolver.AddBindings(IocHelp.Infrastructure.NinjectModule.Bindings);
            //resolver.AddBindings(SciaDesignFormsModel.Module.NinjectModule.Bindings);
            //resolver.AddBindings(SdfCalculationService.Infrastructure.NinjectModule.Bindings);
            System.Web.Mvc.DependencyResolver.SetResolver((System.Web.Mvc.IDependencyResolver)resolver);

        }
    }
}
