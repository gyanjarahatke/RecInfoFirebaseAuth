using Microsoft.Extensions.DependencyInjection;
using RecInfoFirebaseAuth.RnConfig;
using RecInfoFirebaseAuth.RnOpration;
using RecInfoFirebaseAuth.RnPublic;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentlyHttpClient;
using FluentlyHttpClient.Middleware;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;

namespace RecInfoFirebaseAuth
{
    public class InstallRecInfoFirebaseAuth
    {
       
        public static void Install(IServiceCollection services, string apiKey)
        {
            services.AddMediatR(typeof(InstallRecInfoFirebaseAuth));
            services.AddFluentlyHttpClient();
            services.AddScoped<RxRecInfoFirebaseAuthUrlConfig>();
            services.AddScoped(a => new RxRecInfoFirebaseAuthConfig(apiKey));
            services.AddScoped<IRxRecInfoFirebaseAuth, RxRecInfoFirebaseAuth>();
        }


  
        public static void Configure(IApplicationBuilder app)
        {
            var fluentHttpClientFactory = app.ApplicationServices.GetService<IFluentHttpClientFactory>();
            fluentHttpClientFactory?.CreateBuilder(identifier: RxRecInfoFirebaseAuthUrlConfig.HttpPlatformName) // keep a note of the identifier, its needed later
                .WithBaseUrl(RxRecInfoFirebaseAuthUrlConfig.BaseUrl) // required
                .WithHeader("user-agent", "slabs-testify")
                .WithTimeout(5)
                .Register(); // register client builder to factory
        }
        
    }
}
