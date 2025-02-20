using Ordering.API;
using Ordering.Application;
using Ordering.Infrastrucure;

var builder = WebApplication.CreateBuilder(args);


builder.Services
    .AddApplicationServices()
    .AddInfrastructureServices(builder.Configuration)
    .AddApiServices();


var app = builder.Build();

app.UseApiServices();

app.Run();
