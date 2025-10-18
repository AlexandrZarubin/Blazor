using Movies2.Components;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Movies2.Data;

namespace Movies2
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);
			builder.Services.AddDbContextFactory<Movies2Context>(options =>
			    options.UseSqlServer(builder.Configuration.GetConnectionString("Movies2Context") ?? throw new InvalidOperationException("Connection string 'Movies2Context' not found.")));

   builder.Services.AddQuickGridEntityFrameworkAdapter();

   builder.Services.AddDatabaseDeveloperPageExceptionFilter();

			// Add services to the container.
			builder.Services.AddRazorComponents()
				.AddInteractiveServerComponents();

			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (!app.Environment.IsDevelopment())
			{
				app.UseExceptionHandler("/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
    app.UseMigrationsEndPoint();
			}

			app.UseHttpsRedirection();

			app.UseStaticFiles();
			app.UseAntiforgery();

			app.MapRazorComponents<App>()
				.AddInteractiveServerRenderMode();

			app.Run();
		}
	}
}
