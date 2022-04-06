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

namespace RecInfoFirebaseAuth
{
    public class InstallRecInfoFirebaseAuth
    {
        public static void Install(IServiceCollection services, string apiKey)
        {
            services.AddMediatR(typeof(InstallRecInfoFirebaseAuth));
            services.AddFluentlyHttpClient();
            services.AddScoped(a => new RxRecInfoFirebaseAuthConfig(apiKey));
            services.AddScoped<IRxRecInfoFirebaseAuth, RxRecInfoFirebaseAuth>();
        }
    }
}
