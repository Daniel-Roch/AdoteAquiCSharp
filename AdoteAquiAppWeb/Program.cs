using AdoteAquiAppWeb.Data;
using AdoteAquiAppWeb.Interfaces;
using AdoteAquiAppWeb.Services.Data;
using AdoteAquiAppWeb.Services.Mock;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddTransient<IClientAdoptionService, ClientAdoptionService>();
builder.Services.AddTransient<IAnimalsServices, AnimalsServices>();

//Conectar o DB     
builder.Services.AddDbContext<AdoteAquiDbContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment()) {
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
