using Microsoft.EntityFrameworkCore;
using TodoList.Infrastructure.Data;

var builder = WebApplication.CreateBuilder(args);

// Connect to Sql Server (ConnectionStrings) :
// 1 Way : ConnectionStrings
// builder.Services.AddDbContext<DbContextTodoList>(x => x.UseSqlServer("Server=.;Database=TodoList;User Id=MahdiTaremi;Password=123;TrustServerCertificate=True;"));
// 2 Way : ConnectionStrings
builder.Services.AddDbContext<DbContextTodoList>(options =>
{
    var ConnectionStrings = builder.Configuration.GetConnectionString("Local");
    options.UseSqlServer(ConnectionStrings);
});

// 1. Add Swagger 
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add services to the container.
var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseHttpsRedirection();

//2.Add Swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.Run();
