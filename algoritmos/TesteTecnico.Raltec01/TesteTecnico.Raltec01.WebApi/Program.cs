using Microsoft.EntityFrameworkCore;
using TesteTecnico.Raltec01.Application.AutoMapper;
using TesteTecnico.Raltec01.Application.Interfaces;
using TesteTecnico.Raltec01.Application.Services;
using TesteTecnico.Raltec01.Domain.Repositories;
using TesteTecnico.Raltec01.Infra.Data.Context;
using TesteTecnico.Raltec01.Infra.Data.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ApplicationContext>(options =>
{
	options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"),
		sqlServerOptions => sqlServerOptions.EnableRetryOnFailure(2, TimeSpan.FromSeconds(5), null).MigrationsHistoryTable("_version_migration"));
});

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<ISaleService, SaleService>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddAutoMapper(typeof(SaleProfile),
							   typeof(SaleItemProfile));

var app = builder.Build();

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
