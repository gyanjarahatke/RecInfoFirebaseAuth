using RecInfoFirebaseAuth.RnOpration.RnResponse.RnErrorResponse;

namespace RecInfoFirebaseAuth.RnHandlers.RnResponse.RnGlobal;

public class RxRecInfoFirebaseAuthGlobalErrorResponse
{
    private RxGlobalErrorResponse _errorResponse { get; set; }

    protected bool EMAIL_NOT_FOUND => _errorResponse.Error.Message == "EMAIL_NOT_FOUND";

    protected bool INVALID_PASSWORD => _errorResponse.Error.Message == "INVALID_PASSWORD";

    protected bool USER_DISABLED => _errorResponse.Error.Message == "USER_DISABLED";
    
    protected bool EMAIL_EXISTS => _errorResponse.Error.Message == "EMAIL_EXISTS";
    
    protected bool OPERATION_NOT_ALLOWED => _errorResponse.Error.Message == "OPERATION_NOT_ALLOWED";
    
    protected bool TOO_MANY_ATTEMPTS_TRY_LATER => _errorResponse.Error.Message == "TOO_MANY_ATTEMPTS_TRY_LATER";

    public RxRecInfoFirebaseAuthGlobalErrorResponse SetErrorData(RxGlobalErrorResponse errorResponse)
    {
        _errorResponse = errorResponse;
        return this;
    }
}