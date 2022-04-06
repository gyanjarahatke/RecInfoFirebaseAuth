namespace RecInfoFirebaseAuth.RnConfig;

public class RxRecInfoFirebaseAuthUrlConfig
{
    public const string HttpPlatformName = "platform";

    public const string BaseUrl = "https://identitytoolkit.googleapis.com";

    private const string AuthApiVersion = "/v1/";

    private const string AccountKey = "accounts";


    private readonly RxRecInfoFirebaseAuthConfig _authConfig;


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

    public string GetEmailLogInUrl()
    {
        return GetUrl("signInWithPassword");
    }
}