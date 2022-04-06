using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecInfoFirebaseAuth.RnConfig
{
    public class RxRecInfoFirebaseAuthConfig
    {

        
        
        public string FirebaseApiKey { get; set; }

        public RxRecInfoFirebaseAuthConfig(string firebaseApiKey)
        {
            FirebaseApiKey = firebaseApiKey;
        }
    }
}
