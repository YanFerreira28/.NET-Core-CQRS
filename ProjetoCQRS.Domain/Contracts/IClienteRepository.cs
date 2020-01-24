using ProjetoCQRS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCQRS.Domain.Contracts
{
    public interface IClienteRepository
    {
        IEnumerable<Cliente> GetAll();

        Task<Cliente> GetById(int id);

        Task Insert(Cliente obj);

        Task<Cliente> Buscar(Expression<Func<Cliente, bool>> predicate);

        Task Delete(int id);

        Task Update(Cliente obj);

        Task Save();

        void Dispose();
    }
}
