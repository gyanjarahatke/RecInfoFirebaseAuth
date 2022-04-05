using Microsoft.Extensions.DependencyInjection;
using RecInfoFirebaseAuth.RnPublic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecInfoFirebaseAuth
{
    public class InstallRecInfoFirebaseAuth
    {
        public static void Install(IServiceCollection services)
        {
            services.AddFluentlyHttpClient();
            services.AddScoped<IRxRecInfoFirebaseAuth, RxRecInfoFirebaseAuth>();
        }
    }
}
