using System;
using Autofac;


namespace HelloWorld
{
    class Program
    {
        private static IContainer Container { get; set; }

        static void Main( string[] args )
        {
            var builder = new ContainerBuilder();

            // 2. Register types / Configure container
            builder.RegisterType<ConsoleOutput>().As<IOutput>();
            builder.RegisterType<Environment>().As<IEnvironment>();

            // 1. Create a new Container
            Container = builder.Build();

            // 3. Resolve dependency
            IOutput output = Container.Resolve<IOutput>();

            output.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }

    interface IOutput
    {
        void WriteLine(string line);
    }

    interface IEnvironment
    {
        string MachineName();
    }

    class Environment: IEnvironment
    {
        public string MachineName()
        {
            return "Windows::PC1";
        }
    }

    class ConsoleOutput : IOutput
    {
        private IEnvironment m_environment;
		
        public ConsoleOutput(IEnvironment environment)
        {
            m_environment = environment;
        }
		
        public void WriteLine(string line)
        {
            Console.WriteLine( $"{ m_environment.MachineName() } > { line }" );
        }
    }
}
