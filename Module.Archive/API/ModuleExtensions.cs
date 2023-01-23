

using AutoMapper;
using BL.Infrastructure;
using DL.Mapping;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Module.Archive.BL.Abstraction;
using Module.Archive.DL.appDBContext;
using Shared.Infrastructure.Extensions;

namespace Module.Archive.API
{
    public static class ModuleExtensions
    {
        public static IServiceCollection AddArchiveModule(this IServiceCollection services, IConfiguration configuration)
        {
            services
                .AddDatabaseContext<ArchiveAppDbContext>(configuration)
                .AddScoped<IArchiveAppDbContext>(provider => provider.GetService<ArchiveAppDbContext>());
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingConfigration());
                // mc.AddGlobalIgnore("CreatedOn");
                // mc.AddGlobalIgnore("UpdatedOn");
            });

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);

            return services;
        }
    }
}