using System.Globalization;
using Referrals_Service_Command_CA.Application.Common.Interfaces;
using Referrals_Service_Command_CA.Application.TodoLists.Queries.ExportTodos;
using Referrals_Service_Command_CA.Infrastructure.Files.Maps;
using CsvHelper;

namespace Referrals_Service_Command_CA.Infrastructure.Files;

public class CsvFileBuilder : ICsvFileBuilder
{
    public byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records)
    {
        using var memoryStream = new MemoryStream();
        using (var streamWriter = new StreamWriter(memoryStream))
        {
            using var csvWriter = new CsvWriter(streamWriter, CultureInfo.InvariantCulture);

            csvWriter.Configuration.RegisterClassMap<TodoItemRecordMap>();
            csvWriter.WriteRecords(records);
        }

        return memoryStream.ToArray();
    }
}

