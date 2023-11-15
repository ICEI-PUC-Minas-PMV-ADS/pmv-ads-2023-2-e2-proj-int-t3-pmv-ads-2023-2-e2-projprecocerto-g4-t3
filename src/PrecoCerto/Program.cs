using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using PrecoCerto.Models;
using System.Globalization;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.IO;
using static PrecoCerto.Controllers.HomeController;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddRazorPages().AddRazorRuntimeCompilation();

IServiceCollection serviceCollection = builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
    {
        options.IdleTimeout = TimeSpan.FromMinutes(30);
        options.Cookie.HttpOnly = true;
        options.Cookie.IsEssential = true;
    });

// Configurar o Entity Framework Core para usar o SQL Server
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<CarrinhoDeCompra, CarrinhoDeCompra>(); 

builder.Services.Configure<CookiePolicyOptions>(options =>
{
    options.CheckConsentNeeded = Context => true;
    options.MinimumSameSitePolicy = SameSiteMode.None;
});

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.AccessDeniedPath = "/Usuario/AccessDenied/";
        options.LoginPath = "/Usuario/Login";
    });

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

app.UseAuthentication();
app.UseAuthorization();
app.UseSession();

var defaultCulture = new CultureInfo("pt-BR");
var localizationOptions = new RequestLocalizationOptions
{
    DefaultRequestCulture = new RequestCulture(defaultCulture),
    SupportedCultures = new List<CultureInfo> { defaultCulture },
    SupportedUICultures = new List<CultureInfo> { defaultCulture }
};
app.UseRequestLocalization(localizationOptions);

// Inserir dados a partir do arquivo SQL
InserirDadosAPartirDoArquivoSQL(app, app.Environment, app.Services);

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

void InserirDadosAPartirDoArquivoSQL(WebApplication app, IWebHostEnvironment env, IServiceProvider serviceProvider)
{
    using var scope = app.Services.CreateScope();
    var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();

    var configuration = app.Configuration.GetSection("AppConfiguration");
    var operacoesRealizadas = configuration.GetValue<bool>("OperacoesRealizadas");

    if (!operacoesRealizadas)
    {
        // Combine o caminho com a pasta wwwroot
        string filePath = Path.Combine(env.WebRootPath, "sql", "Produtos.sql");

        if (File.Exists(filePath))
        {
            string sql = System.IO.File.ReadAllText(filePath);

            // Execute os comandos SQL em lote
            dbContext.Database.ExecuteSqlRaw(sql);

            // Agora, carregue as imagens da pasta "modalId" e atualize os produtos
            var produtos = dbContext.produtos.ToList();
            foreach (var produto in produtos)
            {
                string imagemPath = Path.Combine(env.WebRootPath, "img", "produtoId", $"{produto.Id}.png"); // Supondo que as imagens sejam nomeadas com base no ID do produto

                if (File.Exists(imagemPath))
                {
                    // Carregue a imagem e atualize o produto
                    using (var stream = new FileStream(imagemPath, FileMode.Open))
                    {
                        using (var memoryStream = new MemoryStream())
                        {
                            stream.CopyTo(memoryStream);
                            produto.Imagem = memoryStream.ToArray();
                            produto.ImagemMimeType = "image/png"; // Altere o tipo MIME para PNG conforme necessário
                        }
                    }
                }

                // Agora, carregue as imagens da pasta "modalId" e atualize os produtos
                string modalImagemPath = Path.Combine(env.WebRootPath, "img", "modalId", $"{produto.Id}.png");

                if (File.Exists(modalImagemPath))
                {
                    using (var stream = new FileStream(modalImagemPath, FileMode.Open))
                    {
                        using (var memoryStream = new MemoryStream())
                        {
                            stream.CopyTo(memoryStream);
                            produto.ModalImagem = memoryStream.ToArray();
                            produto.ModalImagemMimeType = "image/png"; // Altere o tipo MIME para PNG conforme necessário
                        }
                    }
                }
            }

            dbContext.SaveChanges(); // Salve as alterações no banco de dados

            // Atualize a variável de configuração para indicar que as operações foram realizadas
            configuration["OperacoesRealizadas"] = "true";
        }
        else
        {
            Console.WriteLine("O arquivo SQL não foi encontrado.");
        }
    }
    else
    {
        Console.WriteLine("Operações já realizadas.");
    }
}