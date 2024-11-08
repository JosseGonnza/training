using Microsoft.AspNetCore.Mvc;

namespace UserRegistrationNovember.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    [HttpPost(Name = "CreateUser")]
    public IActionResult PostUser(UserRequest request)
    {
        var user = new User(request.Email, request.Password);
        return Ok(user);
    }
}

public record User(string Email, string Password);

public class UserRequest
{
    public string Email { get; set; }
    public string Password { get; set; }
}