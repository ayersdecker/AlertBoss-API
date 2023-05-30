using AlertBoss_API.Databases;
using AlertBoss_API.Models;
using AlertBoss_API.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Database Connection
string connection = builder.Configuration.GetConnectionString("mysqldbcredential");
builder.Services.AddDbContextPool<MySQLDatabase>(options =>
    options.UseMySql(connection, ServerVersion.AutoDetect(connection)));

// Scope Repositories
builder.Services.AddScoped<AlarmRepository>();
builder.Services.AddScoped<AlertRepository>();
builder.Services.AddScoped<ContactRepository>();
builder.Services.AddScoped<DeviceRepository>();
builder.Services.AddScoped<EventRepository>();
builder.Services.AddScoped<SettingRepository>();
builder.Services.AddScoped<UserRepository>();


// Build Action
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();