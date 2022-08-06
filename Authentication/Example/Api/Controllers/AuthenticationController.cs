using Authentication.Example.Authentication;
using Authentication.Example.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Authentication.Example.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthenticationController : ControllerBase
{
    private readonly IAuthenticationService _authService;

    public AuthenticationController(IAuthenticationService authService)
    {
        _authService = authService;
    }

    [HttpPost]
    [Route("login")]
    public async Task<AuthenticationResult> Login(User user)
    {
        return _authService.Login(user);
    }

    [HttpPost]
    [Route("register")]
    public async Task<AuthenticationResult> Register(User user)
    {
        return _authService.Register(user);
    }
}