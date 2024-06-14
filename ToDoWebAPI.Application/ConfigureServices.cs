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
using Convey.CQRS.Commands;
using Microsoft.Extensions.Hosting;
using Convey.CQRS.Queries;
using FluentValidation.AspNetCore;
using FluentValidation.Internal;
using System.Globalization;
using ToDoWebAPI.Application.ToDos.Commands.DeleteToDo;
using ToDoWebAPI.Application.ToDos.Commands.UpdateToDo;


using ToDoWebAPI.Application.ToDos.Commands.CreateToDo;
using ToDoWebAPI.Domain.Repository;
using ToDoWebAPI.Application.ToDos.Query.GetToDoById;


namespace ToDoWebAPI.Application
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddMvc();
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddValidatorsFromAssemblyContaining<DeleteToDoCommandValidator>();
            services.AddTransient<IValidator<GetToDoByIdQuery>, GetToDoByIdValidator>();
            services.AddTransient<IValidator<UpdateToDoCommand>, UpdateToDoCommandValidator>();
            services.AddMediatR(cfg =>
            {
                cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
                
            });


            services.AddFluentValidationAutoValidation(config =>
            {
                config.DisableDataAnnotationsValidation = true;
            });
            services.AddFluentValidationClientsideAdapters();

            services.AddConvey().AddSwaggerDocs();
            services.AddConvey().AddQueryHandlers().AddInMemoryQueryDispatcher();
            services.AddConvey().AddCommandHandlers().AddInMemoryQueryDispatcher();


            return services;
        }


    }
}
