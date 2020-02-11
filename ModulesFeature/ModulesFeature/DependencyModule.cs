using Autofac;
using EnvironmentBusinessLayer;

namespace ModulesFeature
{
    public class DependencyModule : Module
    {
        protected override void Load( ContainerBuilder builder ) 
        {
            builder.RegisterType<ConsoleOutput>().As<IOutput>();
        }
    }
}
