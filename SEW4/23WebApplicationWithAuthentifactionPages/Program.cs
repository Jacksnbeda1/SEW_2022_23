using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using _23WebApplicationWithAuthentifactionPages.Data;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("_23WebApplicationWithAuthentifactionPagesContextConnection") ?? throw new InvalidOperationException("Connection string '_23WebApplicationWithAuthentifactionPagesContextConnection' not found.");

builder.Services.AddDbContext<_23WebApplicationWithAuthentifactionPagesContext>(options => options.UseSqlite(connectionString));

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = false).AddEntityFrameworkStores<_23WebApplicationWithAuthentifactionPagesContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();

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
app.MapRazorPages();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
