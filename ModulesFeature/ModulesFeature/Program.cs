using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
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

            // 1
            // This way assembly is loaded into memory even when the code is never executed
            // This way you can load malicious assembly from your application folder
            var assemblies = Directory
                .EnumerateFiles( Directory.GetCurrentDirectory(), "*.dll", SearchOption.TopDirectoryOnly )
                .Select( Assembly.LoadFrom );

            builder.RegisterAssemblyModules( assemblies.ToArray() );

            // 2
            // builder.RegisterModule( new ModulesFeature.DependencyModule() );
            // builder.RegisterModule( new WindowsEnvironment.DependencyModule() );

            Container = builder.Build();
        }

    }


}
