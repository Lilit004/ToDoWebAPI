using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoWebAPI.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using ToDoWebAPI.Domain.Repository;
using ToDoWebAPI.Infrastructure.Repository;


namespace ToDoWebAPI.Infrastructure
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<ToDoDbContext>(options =>
            
                options.UseSqlServer(configuration.GetConnectionString("ToDoDbContext")
                    ?? throw new InvalidOperationException())
            );
            services.AddTransient<IToDoRepository, ToDoRepository>();
            return services;
        }
    }
}
