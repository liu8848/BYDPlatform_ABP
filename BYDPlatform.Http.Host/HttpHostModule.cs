using BYDPlatform.Application;
using BYDPlatform.EntityFrameworkCore;
using BYDPlatform.EntityFrameworkCore.EntityFrameWorkCore;
using BYDPlatform.Http.Api;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Volo.Abp;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;
using Volo.Abp.Swashbuckle;
using Volo.Abp.UI.Navigation.Urls;

namespace BYDPlatform.Http.Host;

[DependsOn(
    typeof(HttpApiModule),
    typeof(AbpAutofacModule),
    typeof(ApplicationModule),
    typeof(EntityFrameworkCoreModule),
    typeof(AbpSwashbuckleModule)
)]
public class HttpHostModule:AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        var configuration = context.Services.GetConfiguration();
        var webHostEnvironment = context.Services.GetHostingEnvironment();

        context.Services.AddAbpDbContext<BYDPlatformDbContext>();
        
        ConfigureUrls(configuration);
        ConfigureConventionalController();
        ConfigureSwaggerServices(context,configuration);
    }

    public override void OnApplicationInitialization(ApplicationInitializationContext context)
    {
        var app = context.GetApplicationBuilder();
        var env = context.GetEnvironment();

        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        app.UseStaticFiles();
        app.UseRouting();

        app.UseSwagger();
        app.UseSwaggerUI(c =>
        {
            c.SwaggerEndpoint("/swagger/v1/swagger.json", "BYDPlatform API");
        });
        app.UseConfiguredEndpoints();
    }

    /// <summary>
    /// 配置URL
    /// </summary>
    /// <param name="configuration"></param>
    private void ConfigureUrls(IConfiguration configuration)
    {
        Configure<AppUrlOptions>(options =>
        {
            options.Applications["MVC"].RootUrl = configuration["App:SelfUrl"];
            options.RedirectAllowedUrls.AddRange(configuration["App:RedirectAllowedUrls"]?.Split(',') ?? Array.Empty<string>());

            options.Applications["Angular"].RootUrl = configuration["App:ClientUrl"];
        });
    }

    /// <summary>
    /// 配置传统控制器
    /// </summary>
    private void ConfigureConventionalController()
    {
        Configure<AbpAspNetCoreMvcOptions>(options =>
        {
            options
                .ConventionalControllers
                // .Create(typeof(ApplicationModule).Assembly);
                .Create(typeof(HttpApiModule).Assembly);
        });
    }

    /// <summary>
    /// Swagger配置
    /// </summary>
    /// <param name="context"></param>
    /// <param name="configuration"></param>
    private static void ConfigureSwaggerServices(ServiceConfigurationContext context,
        IConfiguration configuration)
    {
        context.Services.AddAbpSwaggerGen(
            options =>
            {
                options.SwaggerDoc("v1",new OpenApiInfo{Title="BYDPlatform API",Version="v1"});
                options.DocInclusionPredicate((docName,description)=>true);
                options.CustomSchemaIds(type=>type.FullName);
            }
        );
    }
}