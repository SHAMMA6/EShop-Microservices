using Ordering.API;
using Ordering.Application;
using Ordering.Infrastrucure;
using Ordering.Infrastrucure.Data.Extentions;

var builder = WebApplication.CreateBuilder(args);


builder.Services
    .AddApplicationServices()
    .AddInfrastructureServices(builder.Configuration)
    .AddApiServices();



var app = builder.Build();

app.UseApiServices();

app.UseApiServices();

if (app.Environment.IsDevelopment())
{
    await app.InitialiseDatabaseAsync();
}

app.Run();
