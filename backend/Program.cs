using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
        policy.WithOrigins("http://localhost:3000")
              .AllowAnyHeader()
              .AllowAnyMethod());
});

builder.Services.AddOpenApi();

var app = builder.Build();

app.UseCors();
app.MapOpenApi();
app.MapScalarApiReference();

app.Run();
