using School.Api;
using School.Core;
using School.Infrastructure;
using School.Service;

var builder = WebApplication.CreateBuilder(args);


builder.Services
    .AddApiServices(builder.Configuration)
    .AddCoreServices()
    .AddServiceServices()
    .AddInfrastructureServices(builder.Configuration);


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
