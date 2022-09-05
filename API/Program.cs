using API.Extensions;
using API.Services;
using Core.Interfaces;
using Core.Models;
using Infrastructure.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add Auth
builder.Services.AddIdentityServices(builder.Configuration);

// DB Connection
builder.Services.AddDbConnection(builder.Configuration);

// Interfaces
builder.Services.AddScoped(typeof(IGenericRepository<>), (typeof(GenericRepository<>)));
builder.Services.AddScoped<ITokenService, TokenService>();

var app = builder.Build();

await using (var scope = app.Services.CreateAsyncScope())
{

    var db = scope.ServiceProvider.GetRequiredService<DatabaseContext>();
    var userManager = scope.ServiceProvider.GetRequiredService<UserManager<User>>();
    await db.Database.MigrateAsync();
    await Seed.SeedUsers(userManager);
    
}

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
