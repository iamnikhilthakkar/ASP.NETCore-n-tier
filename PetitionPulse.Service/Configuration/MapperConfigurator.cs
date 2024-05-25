using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using PetitionPulse.Service.Mapper;

namespace PetitionPulse.Service.Configuration
{
    public static class MapperConfigurator
    {
        public static void AutoMapperConfiguration(this IServiceCollection services)
        {
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new PetitionPulseMapper());
            });

            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}
