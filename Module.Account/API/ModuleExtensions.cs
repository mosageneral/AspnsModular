using BL.Infrastructure;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Module.Account.BL.Abstraction;
using Module.Account.BL.Security;
using Module.Account.DL.appDBContext;
using Module.Account.Helper;
using Shared.Infrastructure.Extensions;
using Shared.Models.Interfaces;
using System.Text;

namespace Module.Account.API
{
    public static class ModuleExtensions
    {
        public static IServiceCollection AddAccountModule(this IServiceCollection services, IConfiguration configuration)
        {
            services
                .AddDatabaseContext<AccountAppDbContext>(configuration)
                .AddScoped<IAccountAppDbContext>(provider => provider.GetService<AccountAppDbContext>());
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<ISMS, SMS>();
            services.AddTransient<IVerifyCodeService, VerifyCodeService>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.Configure<VariableConfig>(configuration.GetSection("VariableConfig"));
            var token = configuration.GetSection("VariableConfig").Get<VariableConfig>();

            services.AddAuthentication(jwtBearerDefaults =>
            {
                jwtBearerDefaults.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                jwtBearerDefaults.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options =>
            {
                options.RequireHttpsMetadata = false;
                options.SaveToken = true;
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(token.TokenSecret)),
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ValidateLifetime = true,
                    ClockSkew = TimeSpan.Zero
                    // ValidIssuer = token.Issuer,
                    // ValidAudience = token.Audience,
                };
            });

            services.AddScoped<IUserManagementService, UserManagementService>();

            services.AddScoped<IAuthenticateService, TokenAuthenticationService>();
            services.AddScoped<IGetUserById, GetUserById>();

            return services;
        }
    }
}