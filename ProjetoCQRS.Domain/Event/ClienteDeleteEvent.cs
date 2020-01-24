using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoCQRS.Domain.Event
{
    public class ClienteDeleteEvent : INotification
    {

        public ClienteDeleteEvent(int ide)
        {
            id = ide;
        }

        public int id { get; set; }

       
    }
}
