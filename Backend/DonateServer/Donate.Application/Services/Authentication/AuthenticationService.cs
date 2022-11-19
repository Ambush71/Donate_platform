using Donate.Application.Interfaces.Authentication;

namespace Donate.Application.Services.Authentication;

public class AuthenticationService:IAuthenticationService
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;

    public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator)
    {
        _jwtTokenGenerator = jwtTokenGenerator;
    }

    public AuthenticationResult Register(string firstName, string lastName, string email, string password)
    {
        var userId = Guid.NewGuid();
        var token = _jwtTokenGenerator.GenerateToken(userId, firstName, lastName);
        return new AuthenticationResult
        {
            Id = userId,
            FirstName = firstName,
            LastName = lastName,
            Email = email,
            Token=token
        };
    }

    public AuthenticationResult Login(string email, string password)
    {
        return new AuthenticationResult
        {
            Id = Guid.NewGuid(),
            Email = email
        };

    }
}