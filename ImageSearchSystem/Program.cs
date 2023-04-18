using ImageSearchSystem.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Windows.Forms;

namespace ImageSearchSystem
{
    static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var host = Host.CreateDefaultBuilder()
                     .ConfigureServices((context, services) =>
                     {
                         ConfigureServices(services);
                         services.AddTransient<ISearchImageService, SearchImageService>();
                     })
                     .Build();

            var services = host.Services;
            var mainForm = services.GetRequiredService<SearchForm>();

            Application.Run(mainForm);
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<SearchForm>();
        }
    }
}