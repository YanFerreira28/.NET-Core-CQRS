using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoCQRS.Domain.Event
{
    public class ClienteRegisterEvent : INotification
    {

        public ClienteRegisterEvent(string name, string fullname, string emails)
        {
            nome = name;
            sobrenome = fullname;
            email = emails;
        }

        public string nome { get; set; }

        public string sobrenome { get; set; }

        public string email
        {
            get; set;
        }
    }
}
