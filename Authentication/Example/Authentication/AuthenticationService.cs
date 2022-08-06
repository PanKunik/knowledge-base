using Authentication.Example.Entities;

namespace Authentication.Example.Authentication;

public class AuthenticationService : IAuthenticationService
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;

    public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator)
    {
        _jwtTokenGenerator = jwtTokenGenerator;
    }

    public AuthenticationResult Login(User user)
    {
        if (user is not { Email: "admin@example.com", Password: "pwd1234" })
        {
            throw new Exception("Not authirized. Bad email or password.");
        }

        var token = _jwtTokenGenerator.GenerateToken(user);
        return new AuthenticationResult(token);
    }

    public AuthenticationResult Register(User user)
    {
        if (user is { Email: "admin@example.com" })
        {
            throw new Exception("Email already in use.");
        }

        var token = _jwtTokenGenerator.GenerateToken(user);
        return new AuthenticationResult(token);
    }
}