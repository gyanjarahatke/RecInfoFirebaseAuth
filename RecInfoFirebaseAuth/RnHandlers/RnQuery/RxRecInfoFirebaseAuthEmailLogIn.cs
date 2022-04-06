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

namespace RecInfoFirebaseAuth.RnHandlers.RnQuery
{

    public class RxRecInfoFirebaseAuthEmailLogIn : IRequestHandler<RxRecInfoFirebaseAuthEmailLogInPaylode, RxRecInfoFirebaseAuthEmailLogInResponse>
    {
        private readonly RxRecInfoFirebaseAuthUrlConfig _authUrlConfig;
        private readonly RxRecInfoFirebaseAuthConfig _authConfig;
        private RxRecInfoFirebaseAuthExecutor<RxEmailLogIn> _executor;
        public RxRecInfoFirebaseAuthEmailLogIn(RxRecInfoFirebaseAuthUrlConfig authUrlConfig,RxRecInfoFirebaseAuthConfig authConfig, FluentHttpClientFactory fluentHttpClientFactory, FluentHttpClient fluentHttpClient)
        {
            _authUrlConfig = authUrlConfig;
            _authConfig = authConfig;
            _executor = new RxRecInfoFirebaseAuthExecutor<RxEmailLogIn>(fluentHttpClientFactory,
                fluentHttpClient);
        }
        
        public async Task<RxRecInfoFirebaseAuthEmailLogInResponse> Handle(RxRecInfoFirebaseAuthEmailLogInPaylode request, CancellationToken cancellationToken)
        {
            var r= await _executor.ExecutorPost(
                _authUrlConfig.GetEmailLogInUrl(_authConfig.FirebaseApiKey),
                new RxEmailLogIn(request.Email,request.Password));
            return null;
        }
    }
}
