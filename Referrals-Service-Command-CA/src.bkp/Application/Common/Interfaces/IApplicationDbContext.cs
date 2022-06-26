using Referrals_Service_Command_CA.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Referrals_Service_Command_CA.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<TodoList> TodoLists { get; }

    DbSet<TodoItem> TodoItems { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}

