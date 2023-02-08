using Ecommerce.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Core.Interfaces
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        Task<IReadOnlyList<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        void DeleteAsync(T entity);
        void UpdateAsync(T entity);
        bool Save(T entity);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
