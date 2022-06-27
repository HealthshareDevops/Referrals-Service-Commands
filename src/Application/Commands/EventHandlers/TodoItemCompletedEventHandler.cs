using Referrals_Service_Command_CA.Domain.Events;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Referrals_Service_Command_CA.Application.TodoItems.EventHandlers;

public class TodoItemCompletedEventHandler : INotificationHandler<TodoItemCompletedEvent>
{
    private readonly ILogger<TodoItemCompletedEventHandler> _logger;

    public TodoItemCompletedEventHandler(ILogger<TodoItemCompletedEventHandler> logger)
    {
        _logger = logger;
    }

    public Task Handle(TodoItemCompletedEvent notification, CancellationToken cancellationToken)
    {
        _logger.LogInformation("Referrals_Service_Command_CA Domain Event: {DomainEvent}", notification.GetType().Name);

        return Task.CompletedTask;
    }
}

