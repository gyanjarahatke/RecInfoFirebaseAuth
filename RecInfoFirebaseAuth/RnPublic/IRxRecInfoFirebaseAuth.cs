using RecInfoFirebaseAuth.RnHandlers.RnQuery.RnRequest;
using RecInfoFirebaseAuth.RnHandlers.RnQuery.RnResponse;

namespace RecInfoFirebaseAuth.RnPublic
{
    public interface IRxRecInfoFirebaseAuth
    {
        public Task<RxRecInfoFirebaseAuthEmailLogInResponse> GoForEmailLogInAsync(RxRecInfoFirebaseAuthEmailLogInPaylode model);
    }
}
