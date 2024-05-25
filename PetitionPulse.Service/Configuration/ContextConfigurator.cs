using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

using PetitionPulse.Repository.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetitionPulse.Service.Configuration
{
    public static class ContextConfigurator
    {
        public static void ContextConfiguration(this IServiceCollection services, string connectionstring)
        {
            services.AddDbContext<PetitionPulseContext>(options => options.UseSqlServer(connectionstring));
        }
    }
}
