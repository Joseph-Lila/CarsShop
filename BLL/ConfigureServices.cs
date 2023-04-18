using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;


namespace BLL
{
    public static class ConfigureServices
    {
        public static void Configure(IServiceCollection services, IConfiguration configuration)
        {
            DAL.ConfigureServices.Configure(services, configuration);
        }
    }
}
