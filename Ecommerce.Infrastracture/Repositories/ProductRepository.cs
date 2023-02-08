using Ecommerce.Core.Entities;
using Ecommerce.Core.Interfaces;
using Ecommerce.Infrastracture.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Infrastracture.Repositories
{
    public class ProductRepository : GenericRepository<Products>, IProductRepository
    {
        public ProductRepository(EcommerceContext context) : base(context)
        {
        }
    }
}
