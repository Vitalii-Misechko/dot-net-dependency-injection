using System;

namespace BusinessLogic.OutputDomain.Default
{
    internal sealed class OutputEnvFormatter : IOutputEnvFormatter
    {
        public string FormatLine( string line ) {
            return $"{DateTime.Now} > {line}";
        }

    }
}
