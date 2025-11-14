using Microsoft.EntityFrameworkCore;
using Project.Models.Entities;
using Microsoft.Extensions;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<DatabaseContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("TechnovaConString")));
   

var app = builder.Build();
