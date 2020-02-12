using System;
using System.Collections.Generic;
using System.Text;

namespace EnvironmentBusinessLayer
{
    public interface IOutput
    {
        void WriteLine(string line);

        string FormatLine( string line );

    }
}
