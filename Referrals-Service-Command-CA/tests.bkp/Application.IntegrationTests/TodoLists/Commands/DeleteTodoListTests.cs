using Referrals_Service_Command_CA.Application.Common.Exceptions;
using Referrals_Service_Command_CA.Application.TodoLists.Commands.CreateTodoList;
using Referrals_Service_Command_CA.Application.TodoLists.Commands.DeleteTodoList;
using Referrals_Service_Command_CA.Domain.Entities;
using FluentAssertions;
using NUnit.Framework;

namespace Referrals_Service_Command_CA.Application.IntegrationTests.TodoLists.Commands;

using static Testing;

public class DeleteTodoListTests : BaseTestFixture
{
    [Test]
    public async Task ShouldRequireValidTodoListId()
    {
        var command = new DeleteTodoListCommand(99);
        await FluentActions.Invoking(() => SendAsync(command)).Should().ThrowAsync<NotFoundException>();
    }

    [Test]
    public async Task ShouldDeleteTodoList()
    {
        var listId = await SendAsync(new CreateTodoListCommand
        {
            Title = "New List"
        });

        await SendAsync(new DeleteTodoListCommand(listId));

        var list = await FindAsync<TodoList>(listId);

        list.Should().BeNull();
    }
}

