using Ardalis.GuardClauses;
using FastCarServer.Application.Common.Interfaces;
using FastCarServer.Application.Common.Interfaces.Data;
using FastCarServer.Core.Data;
using FastCarServer.Infrastructure.Data;
using FastCarServer.Infrastructure.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastCarServer.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfastractureServices(this IServiceCollection services, IConfiguration configuration)
        {
            string connectionString = configuration.GetConnectionString("DevConnection");

            services.AddDbContext<ApplicationDbContext>((sp, options) =>
            {
                options.AddInterceptors(sp.GetServices<ISaveChangesInterceptor>());

                options.UseNpgsql(connectionString, b => b.MigrationsAssembly("FastCarServer.WebAPI"));
            });

            services.AddScoped<IApplicationDbContext>(provider => provider.GetRequiredService<ApplicationDbContext>());
            services.AddScoped<ApplicationDbContextInitialiser>();

            services.AddScoped<IVerificationService, VerificationService>();

            services.AddAuthentication()
            .AddBearerToken(IdentityConstants.BearerScheme);

            services.AddAuthorizationBuilder();

            services
                .AddIdentityCore<ApplicationUser>()
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddApiEndpoints();

            services.AddSingleton(TimeProvider.System);

            return services;
        }
    }
}
