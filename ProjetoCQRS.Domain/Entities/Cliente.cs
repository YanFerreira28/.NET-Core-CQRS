using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoCQRS.Domain.Entities
{
    public class Cliente
    {
        public int id { get; private set; }

        public string nome { get; private set; }

        public string sobrenome { get; private set; }

        public string email { get; private set; }

        public DateTime dataCadastro { get; private set; }

        public Cliente(string name, string fullname, string emails)
        {
            nome = name;
            sobrenome = fullname;
            email = emails;
        }

        public Cliente(int ids,string name, string fullname, string emails)
        {
            id = ids;
            nome = name;
            sobrenome = fullname;
            email = emails;
        }


        public Cliente(int ids)
        {
            id = ids;
        }
    }
}
