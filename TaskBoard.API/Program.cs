using Microsoft.EntityFrameworkCore;
using TaskBoard.BLL.DTO;
using TaskBoard.BLL.Services;
using TaskBoard.Core.Abstractions;
using TaskBoard.DAL;
using TaskBoard.DAL.Configuration;
using TaskBoard.DAL.Entities;
using TaskBoard.DAL.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(TaskCardToDtoProfile), typeof(TaskCardToEntityProfile), typeof(TaskCardDtoToEntityProfile));
builder.Services.AddScoped<ITaskCardService<TaskCardDto>, TaskCardService>();
builder.Services.AddScoped<ITaskCardsRepository<TaskCardEntity>, TaskCardsRepository>();

builder.Services.AddDbContext<TaskBoardDbContext>(
    options =>
    {
        options.UseNpgsql(builder.Configuration.GetConnectionString(nameof(TaskBoardDbContext)));
    });

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
