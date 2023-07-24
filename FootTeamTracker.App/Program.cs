using FootTeamTracker.Data;
using FootTeamTracker.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection.Extensions;
using FootTeamTracker.Web.Infrastructure.Extensions;
using FootTeamTracker.Services.Models.Interfaces;
using FootTeamTracker.Services.Mapping;
using FootTeamTracker.Web.ViewModels.Home;
using System.Reflection;

namespace FootTeamTracker.Web
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.
			var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

			builder.Services.AddDbContext<FootTeamTrackerDbContext>(options =>
				options.UseSqlServer(connectionString));
				



			builder.Services.AddDefaultIdentity<AppUser>(options =>
			{
				options.SignIn.RequireConfirmedAccount =
					builder.Configuration.GetValue<bool>("Identity:SignIn:RequireConfirmedAccount");
				options.Password.RequireLowercase =
					builder.Configuration.GetValue<bool>("Identity:Password:RequireLowercase");
				options.Password.RequireUppercase =
					builder.Configuration.GetValue<bool>("Identity:Password:RequireUppercase");
				options.Password.RequireNonAlphanumeric =
					builder.Configuration.GetValue<bool>("Identity:Password:RequireNonAlphanumeric");
				options.Password.RequiredLength =
					builder.Configuration.GetValue<int>("Identity:Password:RequiredLength");
			})
				.AddRoles<IdentityRole<Guid>>()
				.AddEntityFrameworkStores<FootTeamTrackerDbContext>();



			builder.Services.AddApplicationServices(typeof(ITeamService));

            


            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

			//builder.Services.AddDefaultIdentity<AppUser>(options => options.SignIn.RequireConfirmedAccount = false)
			//	.AddEntityFrameworkStores<FootTeamTrackerDbContext>();
			builder.Services.AddControllersWithViews();

			var app = builder.Build();

			AutoMapperConfig.RegisterMappings(typeof(ErrorViewModel).GetTypeInfo().Assembly);

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
		}
	}
}