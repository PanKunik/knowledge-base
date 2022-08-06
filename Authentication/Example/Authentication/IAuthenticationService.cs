using Authentication.Example.Entities;

namespace Authentication.Example.Authentication;

public interface IAuthenticationService
{
    AuthenticationResult Login(User user);
    AuthenticationResult Register(User user);
}