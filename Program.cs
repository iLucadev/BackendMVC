var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews();
var app = builder.Build();

if(app.Environment.IsDevelopment()) {
  app.UseDeveloperExceptionPage();
} else {
  app.UseExceptionHandler("/error");
}

// Middlewares
//app.UseDefaultFiles(); // Specify the default files
app.UseStaticFiles(); // Add the static files from wwwroot when app is rendered

//app.MapGet("/", () => "Hello World!");

// Routes
app.UseRouting();
app.UseEndpoints(x => {
  x.MapRazorPages();
  x.MapControllerRoute(
    name: "Default",
    pattern: "{controller}/{action}/{id?}",
    defaults: new {Controller = "App", Action = "Index"}
    );
});
  
app.Run();


