using Nexus.Data.Repositories;
using Nexus.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// services configuration
// Services
builder.Services.AddScoped<IPlanetService, PlanetService>();
builder.Services.AddScoped<IRegionService, RegionService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IStructureService, StructureService>();
builder.Services.AddScoped<IMineService, MineService>();
builder.Services.AddScoped<IResourceService, ResourceService>();
builder.Services.AddScoped<IRegionStructureService, RegionStructureService>();

// Repositories
builder.Services.AddScoped<IPlanetRepository, PlanetRepository>();
builder.Services.AddScoped<IRegionRepository, RegionRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IStructureRepository, StructureRepository>();
builder.Services.AddScoped<IMineRepository, MineRepository>();
builder.Services.AddScoped<IResourceRepository, ResourceRepository>();
builder.Services.AddScoped<IRegionStructureRepository, RegionStructureRepository>();

// Use scrutor for scaning and register services and repositories
//builder.Services.Scan(scan => scan
//    .FromAssemblyOf<IPlanetService>()
//    .AddClasses()
//    .AsImplementedInterfaces()
//    .WithScopedLifetime());


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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
