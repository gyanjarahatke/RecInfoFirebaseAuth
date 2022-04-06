namespace RecInfoFirebaseAuth.RnOpration.RnModel;

public class RxEmailLogIn
{
    public RxEmailLogIn(string email, string password)
    {
        Email = email;
        Password = password;
    }

    public string Email { get; set; }
    
    public string Password { get; set; }
}