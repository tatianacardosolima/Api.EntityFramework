using API.DemoDapper.Interfaces.IRepositories;
using API.DemoDapper.Interfaces.IServices;
using API.DemoDapper.Repositories;
using API.DemoDapper.Services;
using API.EntityFramework.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Data.SqlClient;

var builder = WebApplication.CreateBuilder(args);

var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

builder.Services.AddControllers();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//var connectionString = configuration.GetConnectionString("ConnectionStrings");


//builder.Services.AddDbContext<ApplicationDBContext>(options =>
//{
//    options.UseSqlServer(configuration.GetConnectionString("ConnectionStrings"));
//}, ServiceLifetime.Scoped
//); 

builder.Services.AddScoped(serviceProvider =>
{
    var connectionString = configuration.GetConnectionString("ConnectionStrings"); ;
    var options = new DbContextOptionsBuilder<ExampleDBContext>()
        .UseSqlServer(connectionString)
        .Options;

    var userLoggedInfo = 1; // simula o código do usuário
    var context = new ExampleDBContext(options, userLoggedInfo);
    return context;
});


builder.Services.AddScoped<IClientRepository, ClientRepository>();
builder.Services.AddScoped<IPurchaseOrderRepository, PurchaseOrderRepository>();
builder.Services.AddScoped<IPurchaseOrderItemRepository, PurchaseOrderItemRepository>();

builder.Services.AddScoped<IClientService, ClientService>();
builder.Services.AddScoped<IPurchaseOrderService, PurchaseOrderService>();
builder.Services.AddScoped<IPurchaseOrderItemService, PurchaseOrderItemService>();


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






