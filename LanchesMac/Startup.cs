using LanchesMac.Contexto;
using LanchesMac.Repository;
using LanchesMac.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace LanchesMac;
public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllersWithViews();

        //Configurando o Contexto
        services.AddDbContext<AppDbContext>(option => option.
        UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

        //Configurando o Escopo
        services.AddTransient<ILancheRepository, LancheRepository>();
        services.AddTransient<ICategoriaRepository,CategoriaRepository>();

        //Registrando os midware da sessão
        services.AddMemoryCache();
        services.AddSession();

        //Definindo o tempo de vida da Section (Singleton)vale o quanto durar a aplicação
        services.AddSingleton<IHttpContextAccessor,HttpContextAccessor>();
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }
        else
        {
            app.UseExceptionHandler("/Home/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }
        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthorization();

        //Ativando a Sessão
        app.UseSession();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
        });
    }
}