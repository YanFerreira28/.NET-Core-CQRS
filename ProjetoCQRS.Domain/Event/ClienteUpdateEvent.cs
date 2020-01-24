using MediatR;

namespace ProjetoCQRS.Domain.Event
{
    public class ClienteUpdateEvent : INotification
    {

        public ClienteUpdateEvent(int ide, string name, string fullname, string emails)
        {
            id = ide;
            nome = name;
            sobrenome = fullname;
            email = emails;
        }

        public int id { get;  set; }

        public string nome { get;  set; }

        public string sobrenome { get;  set; }

        public string email { get;  set; }


    }
}
