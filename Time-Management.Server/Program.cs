using Microsoft.EntityFrameworkCore;
using Time_Management.Server.Configurations;
using Time_Management.Server.Data;
using Time_Management.Server.Models.ViewModels;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// add DB connection string
builder.Services.AddDbContext<TimeManagementDBContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// add services
builder.Services.AddAutoMapper(typeof(TMAutoMapperProfile));
builder.Services.AddSingleton<IValidationService, ValidationService>();
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
