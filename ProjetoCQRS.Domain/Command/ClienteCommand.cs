using System;

namespace ProjetoCQRS.Domain.Command
{
    public abstract class ClienteCommand
    {
        public int id { get; protected set; }

        public string nome { get; protected set; }

        public string sobrenome { get; protected set; }

        public string email { get; protected set; }

        public DateTime dataCadastro { get; protected set; }
    }
}
