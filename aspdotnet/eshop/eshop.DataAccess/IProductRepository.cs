using eshop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop.DataAccess
{
    public interface IProductRepository : IRepository<Product>
    {
        IEnumerable<Product> GetProductsByName(string productName);
        Task<IEnumerable<Product>> GetProductsByNameAsync(string productName);

        Task<IEnumerable<Product>> GetProductsByCategoryIdAsync(int categoryId);


    }
}
