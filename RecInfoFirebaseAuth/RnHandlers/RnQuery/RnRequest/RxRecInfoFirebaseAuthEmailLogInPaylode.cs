using MediatR;
using RecInfoFirebaseAuth.RnHandlers.RnQuery.RnResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecInfoFirebaseAuth.RnHandlers.RnQuery.RnRequest
{
    public class RxRecInfoFirebaseAuthEmailLogInPaylode : IRequest<RxRecInfoFirebaseAuthEmailLogInResponse>
    {
        public string Email { get; set; }

        public string Password { get; set; }

        public RxRecInfoFirebaseAuthEmailLogInPaylode(string email, string password)
        {
            Email = email;
            Password = password;
        }
    }
}
