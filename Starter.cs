using HomeWork.Providers;
using HomeWork.Providers.Abstractions;
using HomeWork.Services;
using HomeWork.Services.Abstractions;
using Microsoft.Extensions.DependencyInjection;

namespace HomeWork
{
    public class Starter
    {
        public void Run()
        {
            var serviceProvider = new ServiceCollection()
                .AddTransient<IApplianceProvider, ApplianceProvider>()
                .AddTransient<IHomeService, HomeService>()
                .AddTransient<App>()
                .BuildServiceProvider();
            var app = serviceProvider.GetService<App>();

            app?.Run();
        }
    }
}