using Autofac;
using BusinessLogic.ConsoleDomain;
using BusinessLogic.ConsoleDomain.Default;

namespace BusinessLogic
{
    public class DependencyModule : Module
    {
        protected override void Load( ContainerBuilder builder ) 
        {
            builder.RegisterType<OutputEnvFormatter>().As<IOutputEnvFormatter>();
        }
    }
}
