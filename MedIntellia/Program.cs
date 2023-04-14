using MedIntellia.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Service_Broker.NewsApi;
using Service_Broker.Public;
using Service_Broker.RapidAPI;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddHttpClient<IAdviceService, AdviceService>(c =>
{
    c.BaseAddress = new Uri("https://api.adviceslip.com/advice");
});

builder.Services.AddHttpClient<IRapidAPI_Countries, RapidAPI_Countries>(c =>
{
    c.BaseAddress = new Uri("https://wft-geo-db.p.rapidapi.com/v1/geo/adminDivisions");
});
builder.Services.AddHttpClient<ICMI_Service, CMI_Service>(c =>
{
    //c.BaseAddress = new Uri("https://www.communitybenefitinsight.org/api/get_hospital_data.php?hospital_id=1000");
    c.BaseAddress = new Uri("https://www.communitybenefitinsight.org/api/get_hospital_data.php");
});
builder.Services.AddHttpClient<IGeoCoderService, GeoCoderService>(c =>
{
    c.BaseAddress = new Uri("https://geocode.maps.co/search");
});

builder.Services.AddHttpClient<INewsServices, NewsServices>();


var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddControllersWithViews();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();



