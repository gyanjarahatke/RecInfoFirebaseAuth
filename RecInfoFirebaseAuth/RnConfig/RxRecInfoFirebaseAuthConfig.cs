namespace RecInfoFirebaseAuth.RnConfig;

public class RxRecInfoFirebaseAuthConfig
{
    public RxRecInfoFirebaseAuthConfig(string firebaseApiKey)
    {
        FirebaseApiKey = firebaseApiKey;
    }


    public string FirebaseApiKey { get; set; }
}