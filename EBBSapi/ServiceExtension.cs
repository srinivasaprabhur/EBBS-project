using EBBS.DBEngine;
using EBBS.Repository;
using EBBS.Repository.Interfaces;
using EBBS.Service.Implementations;
using EBBS.Service.Interfaces;
using Microsoft.OpenApi.Models;
using System.Reflection;

namespace EBBSApi;
public static class ServiceExtension
{
    public static IServiceCollection AddDIServicesSetups(this IServiceCollection services, IConfiguration configuration)
    {


        // To access the files in web Browsers
        services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

        // Sql Server Repository
        services.AddTransient<ISQLServerHandler, SQLServerHandler>();

        // Repositories 
        services.AddTransient<IEBBSDetailsRepository, EBBSDetailsRepository>();

        // services
        services.AddTransient<IEBBDetailservices, EBBDetailsServices>();


        services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        services.AddEndpointsApiExplorer();

        return services;
    }
    public static IServiceCollection AddSwaggerGenSetups(this IServiceCollection services)
    {
        services.AddSwaggerGen(c =>
        {
            //c.SwaggerDoc("v1", new OpenApiInfo
            //{
            //    Title = "REST API DEMO",
            //    Version = "v1",
            //    Description = "An API to perform Sample Api for project Demo",
            //});


            c.SwaggerDoc("v1", new OpenApiInfo
            {
                Version = "v1",
                Title = "REST API DEMO",
                Description = "A simple example for swagger api information",
                TermsOfService = new Uri("https://example.com/terms"),
                Contact = new OpenApiContact
                {
                    Name = "Your Name XYZ",
                    Email = "xyz@gmail.com",
                    Url = new Uri("https://example.com"),
                },
                License = new OpenApiLicense
                {
                    Name = "Use under OpenApiLicense",
                    Url = new Uri("https://example.com/license"),
                }
            });


            // Go to Project Properties --> Build --> Output  --> XML Documentation File --> Check the checkbox
            // Error and Warning  --> Suppress specific warning ass the ; 1591 and 
            // Output             --> Check the Documentation file
            // Set the comments path for the Swagger JSON and UI.

            var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
            var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
            c.IncludeXmlComments(xmlPath);
        });



        return services;
    }

}





