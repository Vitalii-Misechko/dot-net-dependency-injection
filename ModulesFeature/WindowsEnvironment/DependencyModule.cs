using Autofac;
using EnvironmentBusinessLayer;

namespace WindowsEnvironment
{
    public class DependencyModule : Module
    {
        protected override void Load( ContainerBuilder builder ) 
        {
            builder.RegisterType<Environment>().As<IEnvironment>();
        }
    }
}
