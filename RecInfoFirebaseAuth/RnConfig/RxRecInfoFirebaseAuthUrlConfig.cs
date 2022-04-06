using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecInfoFirebaseAuth.RnConfig
{
    public class RxRecInfoFirebaseAuthUrlConfig
    {
        private const string AuthUrl = "https://identitytoolkit.googleapis.com/v1/";

        private const string AccountKey = "accounts";


        private string GetUrl(string areaKey, string apiKey)
        {
            return $"{AuthUrl}{AccountKey}:{areaKey}?key={apiKey}";
        }

        public string GetSignUpUrl(string apiKey)
        {
            return GetUrl("signUp", apiKey);
        }

        public string GetSignInWithPasswordUrl(string apiKey)
        {
            return GetUrl("signInWithPassword", apiKey);
        }

        
        public string GetEmailLogInUrl(string apiKey)
        {
            return GetUrl("logIn", apiKey);
        }
        
    }
}
