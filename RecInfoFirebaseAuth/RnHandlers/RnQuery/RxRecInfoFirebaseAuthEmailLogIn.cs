using MediatR;
using RecInfoFirebaseAuth.RnHandlers.RnQuery.RnRequest;
using RecInfoFirebaseAuth.RnHandlers.RnQuery.RnResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentlyHttpClient;
using RecInfoFirebaseAuth.RnConfig;
using RecInfoFirebaseAuth.RnOpration;
using RecInfoFirebaseAuth.RnOpration.RnModel;
using RecInfoFirebaseAuth.RnOpration.RnResponse;
using RecInfoFirebaseAuth.RnOpration.RnResponse.RnSuccessResponse;

namespace RecInfoFirebaseAuth.RnHandlers.RnQuery
{

    public class RxRecInfoFirebaseAuthEmailLogIn : IRequestHandler<RxRecInfoFirebaseAuthEmailLogInPaylode, RxRecInfoFirebaseAuthEmailLogInResponse>
    {
        private readonly RxRecInfoFirebaseAuthUrlConfig _authUrlConfig;
        private RxRecInfoFirebaseAuthExecutor<RxEmailLoginSuccessResponse,RxEmailLogIn> _executor;
        public RxRecInfoFirebaseAuthEmailLogIn(RxRecInfoFirebaseAuthUrlConfig authUrlConfig, IFluentHttpClientFactory fluentHttpClientFactory)
        {
            _authUrlConfig = authUrlConfig;
            _executor = new RxRecInfoFirebaseAuthExecutor<RxEmailLoginSuccessResponse,RxEmailLogIn>(fluentHttpClientFactory);
        }
        
        public async Task<RxRecInfoFirebaseAuthEmailLogInResponse> Handle(RxRecInfoFirebaseAuthEmailLogInPaylode request, CancellationToken cancellationToken)
        {
            var r= await _executor.ExecutorPostBody(
                _authUrlConfig.GetEmailLogInUrl(),
                new RxEmailLogIn(request.Email,request.Password, true));
            return null;
        }
    }
}
