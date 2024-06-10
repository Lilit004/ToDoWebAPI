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
using Convey;
using Convey.Docs.Swagger;
using Convey.CQRS.Queries;
using Convey.CQRS.Commands;


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
            services.AddConvey().AddSwaggerDocs();
            services.AddConvey().AddQueryHandlers().AddInMemoryQueryDispatcher();
            services.AddConvey().AddCommandHandlers().AddInMemoryCommandDispatcher();
            return services;
        }
    }
}
