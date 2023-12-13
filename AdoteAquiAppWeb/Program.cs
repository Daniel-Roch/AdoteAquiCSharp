using AdoteAquiAppWeb.Data;
using AdoteAquiAppWeb.Interfaces;
using AdoteAquiAppWeb.Services.Data;
using AdoteAquiAppWeb.Services.Mock;
using Microsoft.EntityFrameworkCore;
using NToastNotify;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages(options => {
                    options.Conventions.AuthorizeFolder("/Breeds");
                })
                .AddNToastNotifyToastr(new ToastrOptions() {
                    ProgressBar = true,
                    PositionClass = ToastPositions.BottomRight,
                    TimeOut = 5000,
                    PreventDuplicates = true,
                });

builder.Services.AddTransient<IClientAdoptionService, ClientAdoptionService>();
builder.Services.AddTransient<IAnimalsServices, AnimalsServices>();

//Conectar o DB     
builder.Services.AddDbContext<AdoteAquiDbContext>();

//Parte que confirma o e-mail, enviando um e-mail
//deixei como false para poder configurar depois
builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = false)
                .AddEntityFrameworkStores<AdoteAquiDbContext>();

//Relacionado a senha e o que precisa
builder.Services.Configure<IdentityOptions>(options => {
    options.Password.RequireDigit = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
    options.Password.RequiredLength = 3;
    // Lockout settings - bloqueio de tentativas
    options.Lockout.MaxFailedAccessAttempts = 30;
    options.Lockout.AllowedForNewUsers = true;
    // User settings - verifica se é novo usuário ou não
    options.User.RequireUniqueEmail = true;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment()) {
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

var context = new AdoteAquiDbContext();
context.Database.Migrate();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseNToastNotify();

//Necessário para o identity - executada a cada página
app.UseAuthentication();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
