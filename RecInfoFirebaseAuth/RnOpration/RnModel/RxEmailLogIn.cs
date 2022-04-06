namespace RecInfoFirebaseAuth.RnOpration.RnModel;

public class RxEmailLogIn
{
    public RxEmailLogIn(string email, string password, bool returnSecureToken)
    {
        Email = email;
        Password = password;
        ReturnSecureToken = returnSecureToken;
    }

    public string Email { get; set; }
    
    public string Password { get; set; }
    
    public bool ReturnSecureToken { get; set; }
}