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
     //pattern: "{controller=Home}/{action=Index}/{id?}");       //1
     //pattern: "{controller=Home}/{action=Index}/{a?}/{b?}");     //2
     //pattern: "{controller=Home}/{action=Index}/{a?}/{b?}/{op?}");            //3
     pattern: "{controller=Home}/{action=Index}"); 


app.Run();
