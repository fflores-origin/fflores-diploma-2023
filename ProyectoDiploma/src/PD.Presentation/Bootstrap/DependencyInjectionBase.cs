using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace PD.Presentation.Bootstrap
{
    public static class DependencyInjectionBase
    {
        public static void AddDependendyInjectionBase(this IServiceCollection services)
        {
            services.AddSingleton<Main>();
            services.AddLogging(configure => configure.AddConsole());
        }
    }
}