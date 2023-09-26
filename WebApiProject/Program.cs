using Microsoft.EntityFrameworkCore;
using WebApiProject.Context;
using WebApiProject.Implementation.Repositorys.Categorys;
using WebApiProject.Implementation.Repositorys.Materials;
using WebApiProject.Implementation.Services.Categorys;
using WebApiProject.Implementation.Services.Materials;
using WebApiProject.Interface.Repositorys.Categorys;
using WebApiProject.Interface.Repositorys.Materials;
using WebApiProject.Interface.Services.Categorys;
using WebApiProject.Interface.Services.Materials;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddDbContext<DatabaseContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("dbCon")));
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<IMaterialService, MaterialService>();
builder.Services.AddScoped<IMaterialRepository, MaterialRepository>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();


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
