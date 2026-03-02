using Microsoft.EntityFrameworkCore;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<TodoDb>(opts =>
    opts.UseNpgsql(builder.Configuration.GetConnectionString("Default"))
);

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
        policy.WithOrigins("http://localhost:3000").AllowAnyHeader().AllowAnyMethod()
    );
});

builder.Services.AddOpenApi();

var app = builder.Build();

TodoEndpoints.Map(app);

app.UseCors();
app.MapOpenApi();
app.MapScalarApiReference();

app.Run();
