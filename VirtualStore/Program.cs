var builder = WebApplication.CreateBuilder(args);

var service = builder.Services;
service.AddControllersWithViews();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
	app.UseDeveloperExceptionPage();
}

app.UseStaticFiles();

app.UseRouting();

app.MapGet("/throw", () =>
{
	throw new ApplicationException("Error");
});
 
app.MapControllerRoute(
	name:"default", 
	pattern:"{controller=Home}/{action=Index}/{id?}");

app.Run();
