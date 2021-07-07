using Domain.Repositories;
using MediatorDemo.Behaviors;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Threading.Tasks;

namespace MediatorDemo
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var host = CreateHostBuilder(args)
                .Build();

            var startup = host.Services.GetService<Startup>();
            await startup.Run();
        }

        static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
            .ConfigureServices((hostContext, services) =>
            {
                services.AddTransient<Startup>();
                services.AddMediatR(typeof(Startup).Assembly);
                services.AddTransient<IProductRepository, ProductRepository>();
                services.AddTransient(typeof(IPipelineBehavior<,>), typeof(FirstBehaviour<,>));
                services.AddTransient(typeof(IPipelineBehavior<,>), typeof(SecondBehavior<,>));
            });
    }
}
