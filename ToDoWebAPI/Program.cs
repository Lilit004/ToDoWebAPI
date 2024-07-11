using Convey;
using Convey.CQRS.Commands;
using Convey.Docs.Swagger;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Diagnostics;
using ToDoWebAPI.Application;
using ToDoWebAPI.Application.ToDos.Commands.DeleteToDo;
using ToDoWebAPI.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddApplicationServices();
builder.Services.AddInfrastructureServices(builder.Configuration);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();


    if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
   

app.Run();
