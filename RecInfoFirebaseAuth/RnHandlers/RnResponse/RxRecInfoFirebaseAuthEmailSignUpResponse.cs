using RecInfoFirebaseAuth.RnHandlers.RnResponse.RnGlobal;

namespace RecInfoFirebaseAuth.RnHandlers.RnResponse;

public class RxRecInfoFirebaseAuthEmailSignUpResponse:
    RxRecInfoFirebaseAuthGlobalHaderResponse
    <RxRecInfoFirebaseAuthEmailSignUpResponse, RxRecInfoFirebaseAuthEmailSignUpSuccessResponse,
        RxRecInfoFirebaseAuthEmailSignUpErrorResponse>
{
}

public class RxRecInfoFirebaseAuthEmailSignUpSuccessResponse
{
    public string LocalId { get; set; }
    public string Email { get; set; }
    public string IdToken { get; set; }
    public string RefreshToken { get; set; }
    public string ExpiresIn { get; set; }
}

public class RxRecInfoFirebaseAuthEmailSignUpErrorResponse : RxRecInfoFirebaseAuthGlobalErrorResponse
{
    public bool EmailExists => EMAIL_EXISTS;

    public bool OperationNotAllowed => OPERATION_NOT_ALLOWED;

    public bool TooManyAttemptsTryLater => TOO_MANY_ATTEMPTS_TRY_LATER;
}