using DeliveryCheckpoint2CSharp.Data;
using Microsoft.EntityFrameworkCore;
using DeliveryCheckpoint2CSharp.Data;

var builder = WebApplication.CreateBuilder(args);

// Adiciona o ApplicationDbContext com Oracle
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseOracle(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
