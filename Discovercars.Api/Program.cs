using Discoverscars.Infrastructure.Implementations.Requests;
using Discoverscars.Infrastructure.Implementations.Requests.RequestServices;
using Discoverscars.Infrastructure.Interfaceses;
using Discoverscars.Infrastructure.Interfaceses.Requests;
using Discoverscars.Infrastructure.Interfaceses.Requests.RequestServices;
using FluentValidation.AspNetCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews().
    AddFluentValidation(options =>
{
    options.ImplicitlyValidateChildProperties = true;
    options.ImplicitlyValidateRootCollectionElements = true;


    options.RegisterValidatorsFromAssembly(Assembly.GetExecutingAssembly());

});

builder.Services.AddTransient<IRequestService, RequestService>();

// 
builder.Services.AddTransient<ILocationService, LocationService>();
builder.Services.AddTransient<IOfferService, OfferService>();
builder.Services.AddTransient<IReservationService, ReservationService>();
builder.Services.AddTransient<INotificationService, NotificationService>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


app.UseExceptionHandler("/Error");


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
