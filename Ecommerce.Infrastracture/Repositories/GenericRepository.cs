using Ecommerce.Core.Entities;
using Ecommerce.Core.Interfaces;
using Ecommerce.Infrastracture.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Infrastracture.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly EcommerceContext _context;
        public GenericRepository(EcommerceContext context)
        {
            _context = context;
        }
        public void Add(T entity)
        {
            _context.Add<T>(entity);
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public void DeleteAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            try
            {
                return await _context.Set<T>().ToListAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<T> GetByIdAsync(int id)
        {
            try
            {
                return await _context.Set<T>().FindAsync(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Save(T entity)
        {
            try
            {
                _context.Add<T>(entity);
                return _context.SaveChanges() > 1;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(T entity)
        {
            _context.Attach<T>(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
