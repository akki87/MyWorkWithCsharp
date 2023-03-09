using Microsoft.Extensions.Configuration;
using RMS.Api.Core.ConfigModels;
using Microsoft.EntityFrameworkCore;
using RMS.Api.Core.Contracts;
using RMS.Api.Infrastructure.Context;
using RMS.Api.Infrastructure.Data.Context;
using RMS.Api.Infrastructure.Repositories;
using RMS.Api.Infrastructure.Validations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
IConfiguration configuration = builder.Configuration;

builder.Services.Configure<GlobalConfig>(builder.Configuration.GetSection("GlobalSettings"));
builder.Host.ConfigureAppConfiguration(config =>
{
    config.AddJsonFile("config.json");
});
//Register dbcontext file as service in the IServiceCollection and configure it to connect to Sql server database.
builder.Services.AddSqlServer<RMSContext>(configuration.GetConnectionString("RMSContext"));
builder.Services.AddScoped<ICustomerRepository, CustomerRepsoitory>();
builder.Services.AddScoped<IDiningSetRepository, DiningSetRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddDbContext<RMSContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("RMSDbConnection")));
builder.Services.AddScoped<ICustomerRepository, CustomerRepsoitory>();
//builder.Services.AddScoped<IUserValidation,UserValidation>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment() || app.Environment.IsProduction())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}
app.UseHttpsRedirection();
app.UseAuthorization();
app.UseAuthentication();

app.MapControllers();

app.Run();
