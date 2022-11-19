namespace Donate.Application.Interfaces.Authentication;

public interface IDateTimeProvider
{
    public DateTime UtcNow { get;}
}