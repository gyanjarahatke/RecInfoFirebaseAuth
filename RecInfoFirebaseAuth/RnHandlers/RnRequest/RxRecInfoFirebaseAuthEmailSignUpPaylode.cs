using MediatR;
using RecInfoFirebaseAuth.RnHandlers.RnResponse;

namespace RecInfoFirebaseAuth.RnHandlers.RnRequest;

public class RxRecInfoFirebaseAuthEmailSignUpPaylode: IRequest<RxRecInfoFirebaseAuthEmailSignUpResponse>
{
    public RxRecInfoFirebaseAuthEmailSignUpPaylode(string email, string password, bool returnSecureToken)
    {
        Email = email;
        Password = password;
        ReturnSecureToken = returnSecureToken;
    }

    public string Email { get; set; }

    public string Password { get; set; }
    
    public bool ReturnSecureToken { get; set; }
}