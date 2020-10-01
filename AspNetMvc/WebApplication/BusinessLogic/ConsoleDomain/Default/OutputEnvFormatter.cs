using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ConsoleDomain.Default
{
    internal sealed class OutputEnvFormatter : IOutputEnvFormatter
    {
        public string FormatLine( string line ) {
            return $"{DateTime.Now} > {line}";
        }

    }
}
