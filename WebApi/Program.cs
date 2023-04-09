using DataAccessEF.ServiceExtension;
using Microsoft.OpenApi.Models;
using Services.Interfaces;
using Services.Services;

var builder = WebApplication.CreateBuilder(args);

// Inject (Add services to the container)
builder.Services.AddIServices(builder.Configuration);
builder.Services.AddScoped<IUserService, UserService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(o =>
{
    o.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "V 1.0",
        Title = "Web API For Unit Of Work Pattern",
        Description = "An ASP.NET Core 7.0 Web API For Unit Of Work Pattern on User Model",
        TermsOfService = new Uri("https://omidsotooni.github.io/"),
        Contact = new OpenApiContact
        {
            Name = "Omid Sotooni",
            Email = "omid.sotooni7@gmail.com",
            Url = new Uri("https://omidsotooni.github.io/")
        },
        License = new OpenApiLicense
        {
            Name = "MIT License",
            Url = new Uri("https://omidsotooni.github.io/")
        }
    });
    o.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(o => o.SwaggerEndpoint("/swagger/v1/swagger.json", "Unit Of Work API - V 1.0"));
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.MapControllers();

app.Run();
