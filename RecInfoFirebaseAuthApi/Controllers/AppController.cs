using Microsoft.AspNetCore.Mvc;
using RecInfoFirebaseAuth.RnHandlers.RnQuery.RnRequest;
using RecInfoFirebaseAuth.RnPublic;

namespace RecInfoFirebaseAuthApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AppController : ControllerBase
    {
        private IRxRecInfoFirebaseAuth _auth;
        public AppController(IRxRecInfoFirebaseAuth auth)
        {
            _auth = auth;
        }
       

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> GoForLogIn()
        {
            await _auth.GoForEmailLogInAsync(new RxRecInfoFirebaseAuthEmailLogInPaylode("sdevpura5@gmail.com", "nokia007007"));
            return Ok();
        }


   
    }
}