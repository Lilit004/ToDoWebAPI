using Convey;
using Convey.CQRS.Commands;
using Convey.Docs.Swagger;
using ToDoWebAPI.Application;
using ToDoWebAPI.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddApplicationServices();
builder.Services.AddInfrastructureServices(builder.Configuration);
//builder.Services.ConfigureService();

builder.Services.AddControllers();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
static IHostBuilder CreateHostBuilder(string[] args)
            => Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.ConfigureServices(services =>
                {
                    services.AddMvcCore();
                    services.AddConvey().AddSwaggerDocs();
                        
                })
                    .Configure(app => app
                        .UseRouting()
                        .UseEndpoints(r => r.MapControllers()));
                    
            });

//builder.Services.AddScoped<ICommandDispatcher>();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
