using alsatcomClient.Services;
using Microsoft.Net.Http.Headers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddHttpClient("Alsatcom", httpClient =>
{
    httpClient.BaseAddress = new Uri("https://localhost:7165/api/");
    
});
builder.Services.AddSingleton<IHttpClientService,HttpClientManager>();

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

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );
    endpoints.MapAreaControllerRoute(
       name: "Seller",
       areaName: "Seller",
       pattern: "{controller=Dashboard}/{action=Index}");
    
    endpoints.MapAreaControllerRoute(
       name:"Admin",
       areaName:"Admin",
       pattern:"{controller=Dashboard}/{action=Index}");
    
    
  

});

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Dashboard}/{action=Index}/{id?}");

app.Run();
