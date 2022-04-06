using RecInfoFirebaseAuth.RnOpration.RnResponse.RnErrorResponse;

namespace RecInfoFirebaseAuth.RnHandlers.RnResponse.RnGlobal;

public class RxRecInfoFirebaseAuthGlobalHaderResponse<TDriving, TSuccess, TError>
    where TError : RxRecInfoFirebaseAuthGlobalErrorResponse
{
    private bool SomethingWentWrong { get; set; }
    public bool IsSomethingWentWrong => SomethingWentWrong || Success == null && Error == null;

    public bool IsSuccess => Success != null;

    public TSuccess? Success { get; set; }

    public TError? Error { get; set; }

    public TDriving SetSomethingWentWrong(TDriving driving)
    {
        SomethingWentWrong = true;
        return driving;
    }

    public TDriving SetSuccess(TDriving driving, TSuccess successResponse)
    {
        Success = successResponse;
        return driving;
    }


    public TDriving SetError(TDriving driving, TError error, RxGlobalErrorResponse errorResponse)
    {
        Error = (TError) error.SetErrorData(errorResponse);
        return driving;
    }
}