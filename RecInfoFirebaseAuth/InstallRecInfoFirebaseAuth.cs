using FluentlyHttpClient;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using RecInfoFirebaseAuth.RnConfig;
using RecInfoFirebaseAuth.RnHandlers.RnResponse;
using RecInfoFirebaseAuth.RnPublic;

namespace RecInfoFirebaseAuth;

public class InstallRecInfoFirebaseAuth
{
    public static void Install(IServiceCollection services, string apiKey)
    {
        services.AddMediatR(typeof(InstallRecInfoFirebaseAuth));
        services.AddFluentlyHttpClient();
        services.AddScoped<RxRecInfoFirebaseAuthUrlConfig>();
        services.AddScoped(a => new RxRecInfoFirebaseAuthConfig(apiKey));
        services.AddScoped<IRxRecInfoFirebaseAuth, RxRecInfoFirebaseAuth>();

        services.AddScoped<RxRecInfoFirebaseAuthEmailLogInResponse>();
    }


    public static void Configure(IApplicationBuilder app)
    {
        var fluentHttpClientFactory = app.ApplicationServices.GetService<IFluentHttpClientFactory>();
        fluentHttpClientFactory
            ?.CreateBuilder(RxRecInfoFirebaseAuthUrlConfig
                .HttpPlatformName) // keep a note of the identifier, its needed later
            .WithBaseUrl(RxRecInfoFirebaseAuthUrlConfig.BaseUrl) // required
            .WithHeader("user-agent", "slabs-testify")
            .WithTimeout(5)
            .Register(); // register client builder to factory
    }
}