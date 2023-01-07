using Applocation.ProductManager;
using Core.Models;
using Core.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using Shared.Mapper;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


string con = builder.Configuration.GetConnectionString("Default");


builder.Services.AddDbContext<SearchTaskContext>(options => options.UseSqlServer(con));

builder.Services.AddTransient(typeof(IUnitOfWork<>), typeof(UnitOfWork<>));
builder.Services.AddTransient<IProductManager, ProductManager>();


builder.Services.AddCors(o => o.AddPolicy("CorsPolicy", builder =>
{
    builder.SetIsOriginAllowed(_ => true)
    .SetIsOriginAllowedToAllowWildcardSubdomains()
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader();
}));
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddAutoMapper(typeof(ProductMapper).Assembly);

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
