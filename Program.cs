using CqrsMediatorPattern.CQRS.Handlers.CommandHandlers;
using CqrsMediatorPattern.CQRS.Handlers.QueryHandlers;
using CqrsMediatorPattern.Data.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContextPool<BookDbContext>(
    options => options.UseSqlServer(builder.Configuration["ConnectionString:SqlDbConnectionString"]));

builder.Services.AddMediatR(typeof(Program));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();