using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WebIdentityScaffold.Areas.Identity.Data;
using WebIdentityScaffold.Data;
namespace WebIdentityScaffold
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var connectionString = builder.Configuration.GetConnectionString("WebIdentityScaffoldContextConnection") ?? throw new InvalidOperationException("Connection string 'WebIdentityScaffoldContextConnection' not found.");

            builder.Services.AddDbContext<WebIdentityScaffoldContext>(options => options.UseSqlServer(connectionString));

            builder.Services.AddDefaultIdentity<WebIdentityScaffoldUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<WebIdentityScaffoldContext>();

            // Add services to the container.
            builder.Services.AddRazorPages();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
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
        }
    }
}
