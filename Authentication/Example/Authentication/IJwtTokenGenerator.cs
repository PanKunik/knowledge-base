using Authentication.Example.Entities;

namespace Authentication.Example.Authentication;

public interface IJwtTokenGenerator
{
    string GenerateToken(User user);
}