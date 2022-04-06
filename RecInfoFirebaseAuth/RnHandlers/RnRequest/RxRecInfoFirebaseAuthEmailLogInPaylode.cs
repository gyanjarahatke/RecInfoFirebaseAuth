using MediatR;
using RecInfoFirebaseAuth.RnHandlers.RnResponse;

namespace RecInfoFirebaseAuth.RnHandlers.RnRequest;

public class RxRecInfoFirebaseAuthEmailLogInPaylode : IRequest<RxRecInfoFirebaseAuthEmailLogInResponse>
{
    public RxRecInfoFirebaseAuthEmailLogInPaylode(string email, string password)
    {
        Email = email;
        Password = password;
    }

    public string Email { get; set; }

    public string Password { get; set; }
}