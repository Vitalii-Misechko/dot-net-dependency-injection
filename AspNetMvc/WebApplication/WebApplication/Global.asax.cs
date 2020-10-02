using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Autofac;
using Autofac.Integration.Mvc;

namespace WebApplication
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters( GlobalFilters.Filters );
            RouteConfig.RegisterRoutes( RouteTable.Routes );
            BundleConfig.RegisterBundles( BundleTable.Bundles );

            SetupDI();
        }

        private void SetupDI() 
        {            
            /*
             * Autofac documentation https://autofaccn.readthedocs.io/en/latest/integration/mvc.html
             * 1. Install Autofac
             * 2. Write the code bellow to register controllers and modules
             */
            var builder = new ContainerBuilder();

            // 2. Register dependencies
            // add a line here if you need to load module
            builder.RegisterModule( new BusinessLogic.DependencyModule() );

            // Register controllers all at once using assembly scanning...
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            // 1. Create a new container
            var container = builder.Build();

            // 3. Register resolver 
            // This line allows to pass dependency into controllers' constructors
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}
