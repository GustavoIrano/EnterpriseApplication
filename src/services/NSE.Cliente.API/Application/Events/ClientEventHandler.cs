using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace NSE.Cliente.API.Application.Events
{
    public class ClientEventHandler : INotificationHandler<ClientRegistradoEvent>
    {
        public Task Handle(ClientRegistradoEvent notification, CancellationToken cancellationToken)
        {
            // Enviar evento de confirmação
            return Task.CompletedTask;
        }

    }
}
