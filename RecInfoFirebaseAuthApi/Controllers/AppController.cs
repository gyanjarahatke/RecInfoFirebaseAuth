using Microsoft.AspNetCore.Mvc;

namespace RecInfoFirebaseAuthApi.Controllers;

[Route("[controller]")]
public class AppController : ControllerBase
{

    public AppController()
    {
        
    }
  
    [HttpPost]
    [Route("[action]")]
    public async Task<IActionResult> EmailSignUp()
    {
        return Ok();
    }
    
    [HttpPost]
    [Route("[action]")]
    public async Task<IActionResult> EmailLogIn()
    {
        return Ok();
    }
}