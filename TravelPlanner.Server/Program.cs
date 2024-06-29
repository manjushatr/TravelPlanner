using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TravelPlanner.Application.Interfaces;
using TravelPlanner.Application.Services;
using TravelPlanner.Infrastructure.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddScoped<IDestinationService, DestinationService>();
//builder.Services.AddScoped<IDestinationService, DestinationService>();
builder.Services.AddScoped<DestinationRepository>();
builder.Services.AddScoped<IFlightService, FlightService>();
builder.Services.AddScoped<FlightRepository>();
builder.Services.AddScoped<IAccommodationService, AccommodationService>();
builder.Services.AddScoped<AccommodationRepository>();
builder.Services.AddScoped<IActivityService, ActivityService>();
builder.Services.AddScoped<ActivityRepository>();

var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapFallbackToFile("/index.html");

app.Run();
