using MediatR;
using RecInfoFirebaseAuth.RnHandlers.RnQuery.RnRequest;
using RecInfoFirebaseAuth.RnHandlers.RnQuery.RnResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecInfoFirebaseAuth.RnPublic
{
    public class RxRecInfoFirebaseAuth : IRxRecInfoFirebaseAuth
    {
        private readonly IMediator _iMediator;

        public RxRecInfoFirebaseAuth(IMediator iMediator)
        {
            _iMediator = iMediator;
        }

        public async Task<RxRecInfoFirebaseAuthEmailLogInResponse> GoForEmailLogInAsync(RxRecInfoFirebaseAuthEmailLogInPaylode model)
        {
            return await _iMediator.Send(model);
        }
    }
}
