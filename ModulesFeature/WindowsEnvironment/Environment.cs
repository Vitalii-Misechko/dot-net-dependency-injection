using System;
using EnvironmentBusinessLayer;

namespace WindowsEnvironment
{
    internal sealed class Environment : IEnvironment
    {
        string IEnvironment.MachineName()
        {
            return "Windows::PC1";
        }
    }
}
