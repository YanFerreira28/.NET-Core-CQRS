using System.Threading;
using System.Threading.Tasks;
using MediatR;
using ProjetoCQRS.Domain.Command;
using ProjetoCQRS.Domain.Contracts;
using ProjetoCQRS.Domain.Entities;
using ProjetoCQRS.Domain.Event;

namespace ProjetoCQRS.Domain.CommandHandler
{
    public class ClienteCommandHandler :
        IRequestHandler<RegisterClienteCommand, bool>,
        IRequestHandler<UpdateClienteCommand, bool>,
        IRequestHandler<DeleteClienteCommand, bool>
    {

        private readonly IMediator _mediator;
        private readonly IClienteRepository _repository;

        public ClienteCommandHandler(IMediator mediator, IClienteRepository clienteRepository)
        {
            _mediator = mediator;
            _repository = clienteRepository;
        }
        public async Task<bool> Handle(RegisterClienteCommand request, CancellationToken cancellationToken)
        {

            if(request == null)
                return await Task.FromResult(false);
           

            var cliente = new Cliente(request.nome, request.sobrenome, request.email);
            await _repository.Insert(cliente);
            await _repository.Save();

            await _mediator.Publish(new ClienteRegisterEvent(cliente.nome, cliente.sobrenome, cliente.email), cancellationToken);

            return await Task.FromResult(true);
            
        }

        public async Task<bool> Handle(UpdateClienteCommand request, CancellationToken cancellationToken)
        {
            if (request == null)
                return false;

            var cliente = new Cliente(request.id, request.nome, request.sobrenome, request.email);
            await _repository.Update(cliente);
            await _repository.Save();

            await _mediator.Publish(new ClienteUpdateEvent(cliente.id, cliente.nome, cliente.sobrenome, cliente.email),cancellationToken);

            return await Task.FromResult(true);
        }

        public async Task<bool> Handle(DeleteClienteCommand request, CancellationToken cancellationToken)
        {

            if (request == null)
                return false;

            var cliente = new Cliente(request.id);
            await _repository.Delete(cliente.id);
            await _repository.Save();
            await _mediator.Publish(new ClienteDeleteEvent(cliente.id),cancellationToken);

            return await Task.FromResult(true);
        }
    }
}
