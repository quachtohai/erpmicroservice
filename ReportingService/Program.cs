using Microsoft.EntityFrameworkCore;
using Microsoft.ReportingServices.Interfaces;
using ReportingService.Datas;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddMvc();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMemoryCache();
builder.Services.AddCors(p => p.AddPolicy("corsapp", builder =>
{
    builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
}));

System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
builder.Services.AddDbContext<ReportingContext>(opts =>
        opts.UseSqlServer(builder.Configuration.GetConnectionString("Database")));

var app = builder.Build();
app.UseMigration();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("corsapp");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
