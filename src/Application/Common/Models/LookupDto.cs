using Referrals_Service_Command_CA.Application.Common.Mappings;
using Referrals_Service_Command_CA.Domain.Entities;

namespace Referrals_Service_Command_CA.Application.Common.Models;

// Note: This is currently just used to demonstrate applying multiple IMapFrom attributes.
public class LookupDto : IMapFrom<TodoList>, IMapFrom<TodoItem>
{
    public int Id { get; set; }

    public string? Title { get; set; }
}

