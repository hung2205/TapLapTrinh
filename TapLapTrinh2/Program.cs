using TapLapTrinh.Models;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ApplicationtestDBContext>(Options =>
    Options.UseSqlServer(builder.Configuration.GetConnectionString("ApplicationDbContextConnection")));

//builder.Services.AddDbContext<ApplicationtestDBContext>(Options =>
//Options.UseSqlServer(connectionString));

var app = builder.Build();
//Register Syscfusion license
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mgo+DSMBPh8sVXJ1S0d+X1RPcEBDQmFJfFBmRGFTe1h6dlVWACFaRnZdQV1mSXxSdEBnWHZXcXNV");

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
