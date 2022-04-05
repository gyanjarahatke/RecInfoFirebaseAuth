using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecInfoFirebaseAuth.RnConfig
{
    public class RxRecInfoFirebaseAuthUrlConfig
    {
        public const string AuthUrl = "https://identitytoolkit.googleapis.com/v1/";

        public const string AccountKey = "accounts";


        private static string GetUrl(string areaKey, string apiKey)
        {
            return string.Format("{0}{1}:{2}?key={3}",AuthUrl, AccountKey, areaKey, apiKey);
        }

        public static string GetSignUpUrl(string apiKey)
        {
            return GetUrl("signUp", apiKey);
        }

        public static string GetSignInWithPasswordUrl(string apiKey)
        {
            return GetUrl("signInWithPassword", apiKey);
        }

        
    }
}
