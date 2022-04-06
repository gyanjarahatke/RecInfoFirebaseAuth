using MediatR;
using RecInfoFirebaseAuth.RnHandlers.RnRequest;
using RecInfoFirebaseAuth.RnHandlers.RnResponse;

namespace RecInfoFirebaseAuth.RnPublic;

public class RxRecInfoFirebaseAuth : IRxRecInfoFirebaseAuth
{
    private readonly IMediator _iMediator;

    public RxRecInfoFirebaseAuth(IMediator iMediator)
    {
        _iMediator = iMediator;
    }

    public async Task<RxRecInfoFirebaseAuthEmailSignUpResponse> GoForEmailSignUpAsync(string email, string password, bool returnSecureToken)
    {
        return await _iMediator.Send(new RxRecInfoFirebaseAuthEmailSignUpPaylode(email,password,returnSecureToken));
    }

    public async Task<RxRecInfoFirebaseAuthEmailLogInResponse> GoForEmailLogInAsync(string email, string password)
    {
        return await _iMediator.Send(new RxRecInfoFirebaseAuthEmailLogInPaylode(email,password));
    }
}