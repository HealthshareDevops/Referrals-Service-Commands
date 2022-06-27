using Referrals_Service_Command_CA.Application.Common.Interfaces;

namespace Referrals_Service_Command_CA.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}

