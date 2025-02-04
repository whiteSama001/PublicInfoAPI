using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using System;
using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});
var app = builder.Build();

// Enable CORS
app.UseCors("AllowAll");

// Define API Endpoint
app.MapGet("/", () =>
{
    var response = new
    {
        email = "skulkid51@gmail.com", 
        current_datetime = DateTime.UtcNow.ToString("o"),
        github_url = "https://github.com/whiteSama001/public-info-api"
    };

    return Results.Json(response, new JsonSerializerOptions { WriteIndented = true });
});

app.Run();
