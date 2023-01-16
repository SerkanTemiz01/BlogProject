using ASP.Net_MyCv.Business.Models.IoC;
using ASP.Net_MyCv.Business.Services.LoginServices;
using ASP.Net_MyCv.DataAccess.Abstract;
using ASP.Net_MyCv.DataAccess.EntityFrameWork.Concrete;
using ASP.Net_MyCv.Presentation.Models.SeedData;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using CurriculumVitae.DataAccess.EntityFramework.Context;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<CvDbContext>(_ =>
{
    _.UseSqlServer(builder.Configuration.GetConnectionString("ConnString"));
});



//Bütün heryeri kapatan kod parçası.

//Filter yapýyoruz ve tek login controllerýna izin vereceðiz.
builder.Services.AddMvc(config =>
{
	var policy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();
	config.Filters.Add(new AuthorizeFilter(policy));
});
//Authentication service
builder.Services.AddAuthentication
	(CookieAuthenticationDefaults.AuthenticationScheme)
	.AddCookie(a =>
	{
		a.LoginPath = "/Login/Login";
	});

builder.Services.AddSession(x =>
{
	x.IdleTimeout = TimeSpan.FromMinutes(5);
});

builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());

builder.Host.ConfigureContainer<ContainerBuilder>(builder =>
{
	builder.RegisterModule(new DependencyResolver());
});



var app = builder.Build();



// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
SeedData.Seed(app);///One user and one 
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseSession();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Admin}/{action=Index}/{id?}");

app.Run();
