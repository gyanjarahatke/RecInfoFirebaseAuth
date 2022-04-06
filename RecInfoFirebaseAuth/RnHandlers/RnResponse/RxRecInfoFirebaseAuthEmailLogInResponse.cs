using RecInfoFirebaseAuth.RnHandlers.RnResponse.RnGlobal;

namespace RecInfoFirebaseAuth.RnHandlers.RnResponse;

public class RxRecInfoFirebaseAuthEmailLogInResponse :
    RxRecInfoFirebaseAuthGlobalHaderResponse
    <RxRecInfoFirebaseAuthEmailLogInResponse, RxRecInfoFirebaseAuthEmailLogInSuccessResponse,
        RxRecInfoFirebaseAuthEmailLogInErrorResponse>
{
}

public class RxRecInfoFirebaseAuthEmailLogInSuccessResponse
{
    public string LocalId { get; set; }
    public string Email { get; set; }
    public string DisplayName { get; set; }
    public bool Registered { get; set; }
    public string IdToken { get; set; }
    public string RefreshToken { get; set; }
    public string ExpiresIn { get; set; }
}

public class RxRecInfoFirebaseAuthEmailLogInErrorResponse : RxRecInfoFirebaseAuthGlobalErrorResponse
{
    public bool EmailNotFound => EMAIL_NOT_FOUND;

    public bool InvalidPassword => INVALID_PASSWORD;

    public bool UserDisabled => USER_DISABLED;
}