using Microsoft.EntityFrameworkCore;
using PekoAsp.Data;
using Microsoft.Extensions.DependencyInjection;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<PekoAspContext>(options =>
	options.UseSqlite(builder.Configuration.GetConnectionString("PekoAspContext") ?? throw new InvalidOperationException("Connection string 'PekoAspContext' not found.")));
if (builder.Environment.IsDevelopment())
{
	builder.Services.AddDbContext<PekoAspContext>(options =>
		options.UseSqlite(builder.Configuration.GetConnectionString("PekoAspContext")));
}
else
{
	builder.Services.AddDbContext<PekoAspContext>(options =>
		options.UseSqlServer(builder.Configuration.GetConnectionString("ProductionMovieContext")));
}

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

app.Run();
