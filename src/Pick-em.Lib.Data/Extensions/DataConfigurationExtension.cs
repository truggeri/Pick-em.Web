using System.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Npgsql;

namespace Pick_em.Lib.Data.Extensions
{
    public static class DataConfigurationExtension
    {
        // http://www.npgsql.org/doc/index.html
        public static void DataConfiguration(this IServiceCollection services, IConfiguration config)
        {
            services.AddSingleton<NpgsqlConnection>(new NpgsqlConnection(config.GetConnectionString("Lib.Data")));
            services.AddSingleton<DatabaseUtils>();
        }
    }
}