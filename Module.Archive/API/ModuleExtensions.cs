﻿

using AutoMapper;
using BL.Infrastructure;
using DL.Mapping;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Module.Product.BL.Abstraction;
using Module.Product.DL.appDBContext;
using Module.Product.Services;
using Shared.Infrastructure.Extensions;
using Shared.Models.Interfaces;

namespace Module.Product.API
{
    public static class ModuleExtensions
    {
        public static IServiceCollection AddProductModule(this IServiceCollection services, IConfiguration configuration)
        {
            services
                .AddDatabaseContext<ProductAppDbContext>(configuration)
                .AddScoped<IProductAppDbContext>(provider => provider.GetService<ProductAppDbContext>());
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IGetProductById, GetProductById>();
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