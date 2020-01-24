using MediatR;
using ProjetoCQRS.Domain.Event;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProjetoCQRS.Domain.EventHandler
{
    public class ClienteEventHandler :
        INotificationHandler<ClienteDeleteEvent>,
        INotificationHandler<ClienteRegisterEvent>,
        INotificationHandler<ClienteUpdateEvent>
    {

        public Task Handle(ClienteDeleteEvent notification, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task Handle(ClienteRegisterEvent notification, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task Handle(ClienteUpdateEvent notification, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
