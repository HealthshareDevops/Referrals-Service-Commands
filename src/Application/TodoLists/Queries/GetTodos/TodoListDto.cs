using Referrals_Service_Command_CA.Application.Common.Mappings;
using Referrals_Service_Command_CA.Domain.Entities;

namespace Referrals_Service_Command_CA.Application.TodoLists.Queries.GetTodos;

public class TodoListDto : IMapFrom<TodoList>
{
    public TodoListDto()
    {
        Items = new List<TodoItemDto>();
    }

    public int Id { get; set; }

    public string? Title { get; set; }

    public string? Colour { get; set; }

    public IList<TodoItemDto> Items { get; set; }
}

