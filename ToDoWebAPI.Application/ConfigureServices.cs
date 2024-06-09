using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using FluentValidation;
using MediatR;
using Convey;
using Convey.Docs.Swagger;
using Microsoft.AspNetCore.Builder;
using Convey.CQRS.Commands;
using Microsoft.Extensions.Hosting;
using Convey.CQRS.Queries;


namespace ToDoWebAPI.Application
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddMediatR(cfg => 
            {
            cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
            cfg.AddBehavior(typeof(IPipelineBehavior<,>), typeof(ToDos.Common.Behaviour.ValidationBehaviour<,>));
            });

            
            services.AddConvey().AddSwaggerDocs();
            services.AddConvey().AddQueryHandlers().AddInMemoryQueryDispatcher();
            
            
            return services;
        }

        
    }
}
