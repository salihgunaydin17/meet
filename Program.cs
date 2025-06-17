var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews(); //mvc servisi eklendi
var app = builder.Build();

app.UseStaticFiles(); //wwwroot klasörünün dışarıya açılması için
app.UseRouting(); //middleware çalıştırılmadan önce eşleştirilmesi için eklenmesinde fayda var



//app.MapDefaultControllerRoute(); // {controller=Home}/{action=Index}/id?
app.MapControllerRoute( // varsayılan domain linki
    name: "default",
    pattern: "{controller=home}/{action=Index}/{id?}"
);

app.Run();
