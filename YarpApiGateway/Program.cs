using Microsoft.AspNetCore.RateLimiting;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors(p => p.AddPolicy("corsapp", builder =>
{
    builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
}));
// Add services to the container.
builder.Services.AddReverseProxy()
    .LoadFromConfig(builder.Configuration.GetSection("ReverseProxy"));

builder.Services.AddRateLimiter(rateLimiterOptions =>
{
    rateLimiterOptions.AddFixedWindowLimiter("fixed", options =>
    {
        options.Window = TimeSpan.FromSeconds(1);
        options.PermitLimit = 500;
    });
});

var app = builder.Build();
app.UseCors("corsapp");
// Configure the HTTP request pipeline.
app.UseRateLimiter();

app.MapReverseProxy();

app.Run();
