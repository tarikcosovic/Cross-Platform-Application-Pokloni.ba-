using AutoMapper;
using Microsoft.AspNet.OData.Extensions;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Pokloni.ba.WebAPI.Database;
using Pokloni.ba.WebAPI.Filters;
using Pokloni.ba.WebAPI.Services;
using Pokloni.ba.WebAPI.Services.Dostava;
using Pokloni.ba.WebAPI.Services.Korisnici;
using Pokloni.ba.WebAPI.Services.Narudzbe;
using Pokloni.ba.WebAPI.Services.Proizvodi;
using Poloni.ba.WebAPI.Security;

namespace Pokloni.ba.WebAPI
{
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
            services.AddMvc(x => x.Filters.Add<ErrorFilter>()).SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddAutoMapper(typeof(Startup));
            services.AddOData();

            //Connection string not hidden due to a part of an assignment in the project
            var connection = @"Server=app.fit.ba,1431;Database=pokloni;User ID=tarikcosovic;Password=Partnership1;";
            services.AddDbContext<PokloniContext>(options => options.UseSqlServer(connection));

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Pokloni.ba API", Version = "v1" });
            });

            services.AddAuthentication("BasicAuthentication")
            .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);


            services.AddScoped<IKorisniciService, KorisniciService>();
            services.AddScoped<IKorisniciDetailsService, KorisniciDetailsService>();
            services.AddScoped<IUlogeService, UlogeService>();
            services.AddScoped<IProizvodacPoklonaService, ProizvodacPoklonaService>();
            services.AddScoped<IKategorijeService, KategorijeService>();
            services.AddScoped<IProizvodiService, ProizvodiService>();
            services.AddScoped<IDostavaService, DostavaService>();
            services.AddScoped<IOcjenaService, OcjenaService>();
            services.AddScoped<IRacunService, RacunService>();
            services.AddScoped<INarudzbaService, NarudzbaService>();
            services.AddScoped<INarudzbaDetailsService, NarudzbaDetailsService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            //app.UseHttpsRedirection();

            app.UseAuthentication();
            app.UseMvc(routeBuilder => 
            {
                routeBuilder.EnableDependencyInjection();
                //Funkcionalnosi OData koje zelimo  koristiti
                routeBuilder.Expand().Select().Count().OrderBy().Filter();
            });
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Pokloni.ba API - V1");
            });
        }
    }
}
