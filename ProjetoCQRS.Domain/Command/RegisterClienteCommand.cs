using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoCQRS.Domain.Command
{
    public class RegisterClienteCommand : ClienteCommand, IRequest<bool>
    {
        public RegisterClienteCommand(string name, string fullname, string emails)
        {
            nome = name;
            sobrenome = fullname;
            email = emails;
        }
    }
}
