using System;
using Autofac;
using EnvironmentBusinessLayer;

namespace ModulesFeature
{
    class Program
    {
        private static IContainer Container { get; set; }

        static void Main( string[] args )
        {
            SetupDI();


            ExecuteSomeBusinessLogic();


            Console.ReadKey();
        }

        private static void ExecuteSomeBusinessLogic() {
            IOutput output = Container.Resolve<IOutput>();
            output.WriteLine( "Hello World!" );
        }

        private static void SetupDI() {
            var builder = new ContainerBuilder();

            builder.RegisterModule( new ModulesFeature.DependencyModule() );
            builder.RegisterModule( new WindowsEnvironment.DependencyModule() );

            Container = builder.Build();
        }

    }


}
