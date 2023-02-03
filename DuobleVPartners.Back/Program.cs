
using BusinessLogic.Implementation;
using BusinessLogic.Interface;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Repository.Context;
using System.Data;
using WorkUnit.Implementation;
using WorkUnit.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
//builder.Services.AddSqlServer<DoubleDbContext>(builder.Configuration.GetConnectionString("conectionString"));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DoubleDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("conectionString"));
});

builder.Services.AddTransient<IDbConnection>((sp) => new SqlConnection(builder.Configuration.GetConnectionString("conectionString")));
builder.Services.AddTransient<IPersonLogic, PersonLogic>();
builder.Services.AddTransient<IUserLogic, UserLogic>();
builder.Services.AddTransient<IAbstractFactoryRepository, AbstractFactoryRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(x => x
          .AllowAnyOrigin()
          .AllowAnyMethod()
          .AllowAnyHeader());


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
