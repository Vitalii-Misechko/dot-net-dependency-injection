using System;
using EnvironmentBusinessLayer;

namespace ModulesFeature
{
    internal sealed class ConsoleOutput : IOutput
    {
        private IEnvironment m_environment;
		
        public ConsoleOutput(IEnvironment environment)
        {
            m_environment = environment;
        }

        void IOutput.WriteLine(string line)
        {
            Console.WriteLine( $"{ m_environment.MachineName() } > { line }" );
        }
    }
}
