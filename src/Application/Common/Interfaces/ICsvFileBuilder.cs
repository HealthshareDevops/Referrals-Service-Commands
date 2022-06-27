using Referrals_Service_Command_CA.Application.TodoLists.Queries.ExportTodos;

namespace Referrals_Service_Command_CA.Application.Common.Interfaces;

public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}

