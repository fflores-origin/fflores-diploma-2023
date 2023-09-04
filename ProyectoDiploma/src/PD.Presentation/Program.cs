using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using PD.Presentation.Bootstrap;
using PD.Presentation.Forms.Login;

namespace PD.Presentation
{
    internal static class Program
    {
        [STAThread]
        private static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();

            ApplicationConfiguration.Initialize();

            using (var serviceScope = host.Services.CreateScope())
            {
                var services = serviceScope.ServiceProvider;

                try
                {
                    Console.WriteLine("Start Program");
                    var mainForm = services.GetRequiredService<Login>();
                    Application.Run(mainForm);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error {errorMessage}", ex.Message);
                }
            }
        }

        private static IHostBuilder CreateHostBuilder(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetParent(AppContext.BaseDirectory).FullName)
                    .AddJsonFile("appsettings.json", false)
                    .Build();

            return Host.CreateDefaultBuilder(args)
                .ConfigureServices((ctx, services) =>
                {
                    services.AddDependendyInjectionBase();
                    services.AddDependencyInjectionRepositories();
                    services.AddDependencyInjectionmanagers();

                    services.AddLogging(configure => configure.AddConsole());
                });
        }
    }
}