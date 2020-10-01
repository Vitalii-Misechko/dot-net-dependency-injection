using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ConsoleDomain
{
    /// <summary>
    /// Appends environment suffix before line
    /// </summary>
    public interface IOutputEnvFormatter
    {
        string FormatLine( string line );

    }
}
