using RecInfoFirebaseAuth.RnHandlers.RnRequest;
using RecInfoFirebaseAuth.RnHandlers.RnResponse;

namespace RecInfoFirebaseAuth.RnPublic;

public interface IRxRecInfoFirebaseAuth
{
    
    public Task<RxRecInfoFirebaseAuthEmailSignUpResponse> GoForEmailSignUpAsync(string email, string password, bool returnSecureToken);
    
    public Task<RxRecInfoFirebaseAuthEmailLogInResponse> GoForEmailLogInAsync(string email, string password);
}