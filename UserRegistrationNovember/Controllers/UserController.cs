using Microsoft.AspNetCore.Mvc;
using UserRegistrationNovember.Models;
using UserRegistrationNovember.Repositories;
using UserRegistrationNovember.ValueObjects;

namespace UserRegistrationNovember.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly UserRepository _userRepository;

    public UserController(UserRepository userRepository)
    {
        this._userRepository = userRepository;
    }
    
    [HttpPost(Name = "CreateUser")]
    public IActionResult PostUser(UserRequest request)
    {
        var user = new User(request.Email, Password.Create(request.Password));
        _userRepository.Save(user);
        return Ok(user.Id);
    }

    [HttpGet(Name = "GetUsers")]
    public IActionResult GetUsers()
    {
        var users = _userRepository.GetAll();
        return Ok(users);
    }
}