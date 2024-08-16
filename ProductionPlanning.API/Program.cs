
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using BuildingBlocks.Behaviors;
using BuildingBlocks.Exceptions.Handler;
using Carter;
using Material.Grpc;
using HealthChecks.UI.Client;
using ProductionPlanning.API;
using Product.Grpc;
using DictionaryInfo.Grpc;
using Microsoft.EntityFrameworkCore;
using ProductionPlanning.API.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//Application Services
var assembly = typeof(Program).Assembly;
builder.Services.AddCarter();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddApplicationServices(builder.Configuration);
builder.Services.AddDbContext<ProductionPlanningContext>(opts =>
        opts.UseSqlServer(builder.Configuration.GetConnectionString("Database")));
builder.Services.AddApplicationServices(builder.Configuration);
//Grpc Services
builder.Services.AddGrpcClient<MaterialProtoService.MaterialProtoServiceClient>(options =>
{
    options.Address = new Uri(builder.Configuration["GrpcSettings:ItemUrl"]!);
})
.ConfigurePrimaryHttpMessageHandler(() =>
{
    var handler = new HttpClientHandler
    {
        ServerCertificateCustomValidationCallback =
        HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
    };

    return handler;
});
builder.Services.AddGrpcClient<ProductProtoService.ProductProtoServiceClient>(options =>
{
    options.Address = new Uri(builder.Configuration["GrpcSettings:ItemUrl"]!);
})
.ConfigurePrimaryHttpMessageHandler(() =>
{
    var handler = new HttpClientHandler
    {
        ServerCertificateCustomValidationCallback =
        HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
    };

    return handler;
});

builder.Services.AddGrpcClient<DictionaryInfoProtoService.DictionaryInfoProtoServiceClient>(options =>
{
    options.Address = new Uri(builder.Configuration["GrpcSettings:ItemUrl"]!);
})
.ConfigurePrimaryHttpMessageHandler(() =>
{
    var handler = new HttpClientHandler
    {
        ServerCertificateCustomValidationCallback =
        HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
    };

    return handler;
});

builder.Services.AddCors(p => p.AddPolicy("corsapp", builder =>
{
    builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
}));
//Cross-Cutting Services
builder.Services.AddExceptionHandler<CustomExceptionHandler>();

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
   
    app.UseSwagger();
    app.UseSwaggerUI();
}
// Configure the HTTP request pipeline.
app.MapCarter();
app.UseExceptionHandler(options => { });
app.UseCors("corsapp");
app.Run();
