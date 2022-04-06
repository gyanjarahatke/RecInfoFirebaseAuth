using FluentlyHttpClient;
using MediatR;
using RecInfoFirebaseAuth.RnConfig;
using RecInfoFirebaseAuth.RnHandlers.RnRequest;
using RecInfoFirebaseAuth.RnHandlers.RnResponse;

namespace RecInfoFirebaseAuth.RnHandlers.RnOpration;

public class RxRecInfoFirebaseAuthEmailLogIn :
    RxRecInfoFirebaseAuthMasterHandler<RxRecInfoFirebaseAuthEmailLogInSuccessResponse, RxRecInfoFirebaseAuthEmailLogInPaylode>,
    IRequestHandler<RxRecInfoFirebaseAuthEmailLogInPaylode, RxRecInfoFirebaseAuthEmailLogInResponse>
{
    private readonly RxRecInfoFirebaseAuthEmailLogInResponse _response;

    public RxRecInfoFirebaseAuthEmailLogIn(RxRecInfoFirebaseAuthEmailLogInResponse response,
        RxRecInfoFirebaseAuthUrlConfig authUrlConfig, IFluentHttpClientFactory fluentHttpClientFactory)
        : base(authUrlConfig, fluentHttpClientFactory)
    {
        _response = response;
    }

    public async Task<RxRecInfoFirebaseAuthEmailLogInResponse> Handle(RxRecInfoFirebaseAuthEmailLogInPaylode request,
        CancellationToken cancellationToken)
    {
        try
        {
            var r = await Executor.ExecutorPostBody(
                AuthUrlConfig.GetEmailLogInUrl(),
                request);
            if (r.SomethingWentWrong) _response.SetSomethingWentWrong(_response);

            if (r.IsSuccess) return _response.SetSuccess(_response, r.SuccessResponse);

            return _response.SetError(_response, new RxRecInfoFirebaseAuthEmailLogInErrorResponse(), r.ErrorResponse);
        }
        catch (Exception e)
        {
            return _response.SetSomethingWentWrong(_response);
        }
    }
}