using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoCQRS.Domain.Command
{
    public class DeleteClienteCommand : ClienteCommand, IRequest<bool>
    {
        public DeleteClienteCommand(int identifica)
        {
            id = identifica;
        }
        
    }
}
