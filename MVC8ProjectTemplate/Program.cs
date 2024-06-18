using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MVC8ProjectTemplate;
using MVC8ProjectTemplate.Data;

namespace MVC8ProjectTemplate
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            MoreFeatures.SetupIdentityDB(builder);
            MoreFeatures.SetupIdentityOptions(builder);


            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            await MoreFeatures.EnsureDatabaseExist(app);

#if (SeedUserData)
                 await MoreFeatures.SeedIdentityUser (app);
#endif

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

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            app.MapRazorPages();

            app.Run();
        }
    }
}
