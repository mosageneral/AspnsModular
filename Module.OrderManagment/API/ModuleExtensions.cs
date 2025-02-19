﻿using AutoMapper;
using BL.Infrastructure;
using DL.Mapping;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Module.OrderManagment.BL.Abstraction;
using Module.OrderManagment.BL.Services;
using Module.OrderManagment.DL.appDBContext;
using Shared.Infrastructure.Extensions;
using Shared.Models.Interfaces;

namespace Module.OrderManagment.API
{
    public static class ModuleExtensions
    {
        public static IServiceCollection AddOrderManagmentModule(this IServiceCollection services, IConfiguration configuration)
        {
            services
                .AddDatabaseContext<OrderManagmentAppDbContext>(configuration)
                .AddScoped<IOrderManagmentAppDbContext>(provider => provider.GetService<OrderManagmentAppDbContext>());
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IGetOrderItems, GetOrderItems>();

          

            return services;
        }
    }
}