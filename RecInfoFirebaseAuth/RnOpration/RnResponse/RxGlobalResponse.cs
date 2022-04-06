using RecInfoFirebaseAuth.RnOpration.RnResponse.RnErrorResponse;

namespace RecInfoFirebaseAuth.RnOpration.RnResponse;

public class RxGlobalResponse<TSuccess>
{
    public TSuccess? SuccessResponse { get; set; }

    public RxGlobalErrorResponse? ErrorResponse { get; set; }

    public bool IsSuccess => SuccessResponse != null;

    public bool SomethingWentWrong => SuccessResponse == null && ErrorResponse == null;


    public RxGlobalResponse<TSuccess> SetSuccess(TSuccess successResponse)
    {
        SuccessResponse = successResponse;
        return this;
    }

    public RxGlobalResponse<TSuccess> SetError(RxGlobalErrorResponse errorResponse)
    {
        ErrorResponse = errorResponse;
        return this;
    }
}