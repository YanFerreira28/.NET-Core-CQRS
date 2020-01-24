using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoCQRS.Domain.Command
{
    public class UpdateClienteCommand : ClienteCommand, IRequest<bool>
    {
        public UpdateClienteCommand(int identifica, string name, string fullname, string emails)
        {
            id = identifica;
            nome = name;
            sobrenome = fullname;
            email = emails;
        }
    }
}
