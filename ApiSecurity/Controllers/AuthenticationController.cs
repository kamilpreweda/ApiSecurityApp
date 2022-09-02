using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiSecurity.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthenticationController : ControllerBase
{
    private readonly IConfiguration _config;

    public AuthenticationController(IConfiguration config)
    {
        _config = config;
    }

    public record AuthenticationData(string? UserName, string? Password);
    public record UserData(int UserId, string UserName);
    [HttpPost("token")]
    public ActionResult<string> Authenticate([FromBody] AuthenticationData data)
    {

    }
    private UserData? ValidateCredentials(AuthenticationData data)
    {
        // THIS IS NOT PRODUCTION CODE - THIS IS ONLY A DEMO - DO NOT USE IN REAL LIFE
        if(CompareValues(data.UserName, "tcorey")&&
            CompareValues(data.Password, "Test123")){
            return new UserData(1, data.UserName!);
        }
        return null;
    }
    private bool CompareValues(string? actual, string expected)
    {
        if(actual is not null)
        {
            if (actual.Equals(expected))
                {
                return true;
                }
        }
        return false;
    }
    private string GenerateToken(UserData user)
    {

    }
} 
