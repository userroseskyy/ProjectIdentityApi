using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ProjectIdentityApi.Data;
using ProjectIdentityApi.Entities;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionstring = builder.Configuration.GetConnectionString("DefultConnection");
builder.Services.AddDbContext<DataBaseContext>(options=> options.UseSqlServer(connectionstring));
builder.Services.AddIdentity<User, Role>()
     .AddEntityFrameworkStores<DataBaseContext>()
        .AddDefaultTokenProviders();

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi

builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
