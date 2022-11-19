using Donate.Application.Interfaces.Authentication;

namespace Donate.Application.Services;

public class DateTimeProvider:IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}