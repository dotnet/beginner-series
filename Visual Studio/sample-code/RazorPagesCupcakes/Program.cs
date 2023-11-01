using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorPagesCupcakes.Data;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
// AddDB
builder.Services.AddDbContext<RazorPagesCupcakesContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("RazorPagesCupcakesContext") ?? throw new InvalidOperationException("Connection string 'RazorPagesCupcakesContext' not found.")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.MapControllerRoute( name: "default", pattern: "{controller=HelloWorld}/{action=Index}/{id?}");

//int IncrementByOne(int source, int increment = 1) // Use expression body for local function
//{
//    return source + increment;
//}

//Console.WriteLine(IncrementByOne(5)); // 6

app.Run();
