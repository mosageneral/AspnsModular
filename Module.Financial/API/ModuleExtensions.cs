


using AutoMapper;
using BL.Infrastructure;
using DL.Mapping;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Module.Financial.BL.Abstraction;
using Module.Financial.DL.appDBContext;

using Shared.Infrastructure.Extensions;


namespace Module.Financial.API
{
    public static class ModuleExtensions
    {
        public static IServiceCollection AddFinancialModule(this IServiceCollection services, IConfiguration configuration)
        {
            services
                .AddDatabaseContext<FinancialAppDbContext>(configuration)
                .AddScoped<IFinancialAppDbContext>(provider => provider.GetService<FinancialAppDbContext>());
            services.AddTransient<IUnitOfWork, UnitOfWork>();
           

            return services;
        }
    }
}