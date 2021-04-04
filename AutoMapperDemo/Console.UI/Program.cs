using Console.UI.Helpers;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Console.UI
{
    class Program
    {
        static IHost ConfigureServices()
        {
            return Host.CreateDefaultBuilder()
                       .ConfigureServices((context, services) =>
                       {
                           services.AddTransient<Startup>();
                           services.AddAutoMapper(c => c.AddProfile<MappingProfile>());  // Add MappingProfile for AutoMapper (this class contains all mappings for Domain Objects -> DTO
                       })
                       .Build();
        }

        static void Main(string[] args)
        {
            var host = ConfigureServices();
            var services = host.Services.GetService<Startup>();
            services.Run();
        }
    }
}
