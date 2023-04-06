using Microsoft.EntityFrameworkCore;
using System;
using ToDoListProjectTest;
using ToDoListProjectTest.Dal;
using ToDoListProjectTest.Dal.Interfaces;
using ToDoListProjectTest.Dal.Repository;
using ToDoListProjectTest.Domain.Entity;
using ToDoListProjectTest.Service.Implementations;
using ToDoListProjectTest.Service.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


//Repo Register
//but we can create Init class and use in here
//builder.Services.AddScoped<IBaseRepository<TaskEntity>,TaskRepository>();
builder.Services.RegisterRepositories();

builder.Services.AddDbContext<AppDbContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddRazorPages().AddRazorRuntimeCompilation();
//builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();// this form use are equal

//nado obezatelno eti punkti tut zareqat v class Programm shtobi vse rabotalo!!!
builder.Services.AddScoped<IBaseRepository<TaskEntity>, TaskRepository>();
builder.Services.AddScoped<ITaskService, TaskService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Task}/{action=Index}/{id?}");

app.Run();
