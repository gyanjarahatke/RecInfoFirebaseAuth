using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecInfoFirebaseAuth.RnConfig
{
    public class RxRecInfoFirebaseAuthUrlConfig
    {
        
        
        
        private readonly RxRecInfoFirebaseAuthConfig _authConfig;
        
        
        public const string HttpPlatformName = "platform";
        
        public const string BaseUrl = "https://identitytoolkit.googleapis.com";
        
        private const string AuthApiVersion = "/v1/";

        private const string AccountKey = "accounts";


        public RxRecInfoFirebaseAuthUrlConfig(RxRecInfoFirebaseAuthConfig authConfig)
        {
            _authConfig = authConfig;
        }
        

        private string GetUrl(string areaKey)
        {
            return $"{BaseUrl}{AuthApiVersion}{AccountKey}:{areaKey}?key={_authConfig.FirebaseApiKey}";
        }

        public string GetSignUpUrl()
        {
            return GetUrl("signUp");
        }

        public string GetSignInWithPasswordUrl()
        {
            return GetUrl("signInWithPassword");
        }

        
        public string GetEmailLogInUrl()
        {
            return GetUrl("signInWithPassword");
        }
        
    }
}
