using Referrals_Service_Command_CA.Application.Common.Mappings;
using Referrals_Service_Command_CA.Domain.Entities;

namespace Referrals_Service_Command_CA.Application.TodoLists.Queries.ExportTodos;

public class TodoItemRecord : IMapFrom<TodoItem>
{
    public string? Title { get; set; }

    public bool Done { get; set; }
}

