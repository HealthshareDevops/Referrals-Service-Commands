using System.Globalization;
using Referrals_Service_Command_CA.Application.TodoLists.Queries.ExportTodos;
using CsvHelper.Configuration;

namespace Referrals_Service_Command_CA.Infrastructure.Files.Maps;

public class TodoItemRecordMap : ClassMap<TodoItemRecord>
{
    public TodoItemRecordMap()
    {
        AutoMap(CultureInfo.InvariantCulture);

        Map(m => m.Done).ConvertUsing(c => c.Done ? "Yes" : "No");
    }
}

