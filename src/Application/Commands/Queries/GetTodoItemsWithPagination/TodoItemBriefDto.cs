using Referrals_Service_Command_CA.Application.Common.Mappings;
using Referrals_Service_Command_CA.Domain.Entities;

namespace Referrals_Service_Command_CA.Application.TodoItems.Queries.GetTodoItemsWithPagination;

public class TodoItemBriefDto : IMapFrom<TodoItem>
{
    public int Id { get; set; }

    public int ListId { get; set; }

    public string? Title { get; set; }

    public bool Done { get; set; }
}

