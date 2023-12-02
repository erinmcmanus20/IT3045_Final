using IT3045_Final.Data;
using IT3045_Final.Interfaces;

using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;

using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);
var startup = new IT3045_Final.Startup(builder.Configuration);
startup.ConfigureServices(builder.Services);

var app = builder.Build();

// Add services to the container.
// builder.Services.AddControllersWithViews();
// builder.Services.AddSwaggerDocument();
// builder.Services.AddMvc(options => options.EnableEndpointRouting = false);
 startup.Configure(app, builder.Environment);









app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
