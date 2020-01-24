using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoCQRS.Domain.Contracts;
using ProjetoCQRS.Domain.Entities;
using ProjetoCQRS.Infrastructure.Data;

namespace ProjetoCQRS.Infrastructure.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        public DataContext _context;

        public ClienteRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<Cliente> Buscar(Expression<Func<Cliente, bool>> predicate)
        {
            return await _context.Set<Cliente>().Where(predicate).FirstOrDefaultAsync();
        }

        public async Task Delete(int id)
        {
            var ide = await _context.Set<Cliente>().FindAsync(id);
            _context.Remove(ide);
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public IEnumerable<Cliente> GetAll()
        {
            return _context.Set<Cliente>().ToList();
        }

        public async Task<Cliente> GetById(int id)
        {
            return await _context.Set<Cliente>().FindAsync(id);
        }

        public async Task Insert(Cliente obj)
        {
            await Task.Run(() => _context.Set<Cliente>().Add(obj));
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }

        public async Task Update(Cliente obj)
        {
            await Task.Run(() => _context.Entry(obj).State = EntityState.Modified);
        }
    }
}
