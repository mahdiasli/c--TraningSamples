var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();
app.MapDefaultControllerRoute();
app.UseStaticFiles();

//app.MapGet("/", () => "Hello World!");

app.Run();
