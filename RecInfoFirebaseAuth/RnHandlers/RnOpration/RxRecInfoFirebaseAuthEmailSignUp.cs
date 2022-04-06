using FluentlyHttpClient;
using MediatR;
using RecInfoFirebaseAuth.RnConfig;
using RecInfoFirebaseAuth.RnHandlers.RnRequest;
using RecInfoFirebaseAuth.RnHandlers.RnResponse;

namespace RecInfoFirebaseAuth.RnHandlers.RnOpration;

public class RxRecInfoFirebaseAuthEmailSignUp:
    RxRecInfoFirebaseAuthMasterHandler<RxRecInfoFirebaseAuthEmailSignUpSuccessResponse, RxRecInfoFirebaseAuthEmailSignUpPaylode>,
    IRequestHandler<RxRecInfoFirebaseAuthEmailSignUpPaylode, RxRecInfoFirebaseAuthEmailSignUpResponse>
{
    private readonly RxRecInfoFirebaseAuthEmailSignUpResponse _response;

    public RxRecInfoFirebaseAuthEmailSignUp(RxRecInfoFirebaseAuthEmailSignUpResponse response,
        RxRecInfoFirebaseAuthUrlConfig authUrlConfig, IFluentHttpClientFactory fluentHttpClientFactory)
        : base(authUrlConfig, fluentHttpClientFactory)
    {
        _response = response;
    }

    public async Task<RxRecInfoFirebaseAuthEmailSignUpResponse> Handle(RxRecInfoFirebaseAuthEmailSignUpPaylode request,
        CancellationToken cancellationToken)
    {
        try
        {
            var r = await Executor.ExecutorPostBody(
                AuthUrlConfig.GetSignUpUrl(),
                request);
            if (r.SomethingWentWrong) _response.SetSomethingWentWrong(_response);

            if (r.IsSuccess) return _response.SetSuccess(_response, r.SuccessResponse);

            return _response.SetError(_response, new RxRecInfoFirebaseAuthEmailSignUpErrorResponse(), r.ErrorResponse);
        }
        catch (Exception e)
        {
            return _response.SetSomethingWentWrong(_response);
        }
    }
}