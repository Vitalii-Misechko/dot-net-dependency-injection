using Autofac;
using BusinessLogic.OutputDomain;
using BusinessLogic.OutputDomain.Default;

namespace BusinessLogic
{
    public class DependencyModule : Module
    {
        protected override void Load( ContainerBuilder builder ) 
        {
            builder.RegisterType<OutputEnvFormatter>().As<IOutputEnvFormatter>();
            builder.RegisterType<DateProvider>().As<IDateProvider>();
        }
    }
}
