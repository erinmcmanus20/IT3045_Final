using IT3045_Final.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);
//public IConfiguration Configuration { get; }

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSwaggerDocument();
builder.Services.AddMvc(options => options.EnableEndpointRouting = false);


//builder.Services.AddDbContext<TeamMemberContext>(options =>
    //options.UseSqlServer(Configuration.GetConnectionString("TeamMemberContext")));
//builder.Services.AddDbContext<TeamMemberContext>(options =>
    //options.UseSqlServer(GetConnectionString("TeamMemberContext")));

//public static string? public static string? GetConnectionString (this Microsoft.Extensions.Configuration.IConfiguration configuration, string name);;



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseOpenApi();
app.UseSwaggerUi3();
app.UseMvc();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();



app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
