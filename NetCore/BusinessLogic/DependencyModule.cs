using System;
using BusinessLogic.OutputDomain;
using BusinessLogic.OutputDomain.Default;
using Microsoft.Extensions.DependencyInjection;

namespace BusinessLogic
{
    public class DependencyModule 
    {

        public static void ConfigureServices(IServiceCollection services) 
        {
            services.AddScoped<IOutputEnvFormatter, OutputEnvFormatter>();
        }

    }
}
