using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public static class ServiceExtension
    {
        public static ConfigurationManager Configuration { get; set; }

        public static void AddDomainContext(this IServiceCollection services, ConfigurationManager configuration)
        {
            Configuration = configuration;
            services.AddDbContext<PegawaiDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DB_Conn"));
            });
        }
    }
}
