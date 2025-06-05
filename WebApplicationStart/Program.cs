var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

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

app.MapControllerRoute(
    name: "Task2",
    pattern: "{controller=Home}/{action=Task2}/{a}/{b}");

app.MapControllerRoute(
    name: "Task3",
    pattern: "{controller=Home}/{action=Task3}/{a}/{b}/{c}");

app.MapControllerRoute(
    name: "Task4",
    pattern: "{controller=Home}/{action=Task4}/{a}/{b}/{c}");

app.Run();
