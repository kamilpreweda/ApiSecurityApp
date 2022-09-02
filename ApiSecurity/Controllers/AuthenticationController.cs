using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiSecurity.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthenticationController : ControllerBase
{
    public record AuthenticationData(string? UserName, string? Password);
    [HttpPost("token")]
    public ActionResult<string> Authenticate([FromBody] Data data)
    {

    }
} 
