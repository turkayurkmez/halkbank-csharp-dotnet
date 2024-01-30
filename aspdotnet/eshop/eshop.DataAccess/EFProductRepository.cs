using eshop.DataAccess.DataContext;
using eshop.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop.DataAccess
{
    public class EFProductRepository : IProductRepository
    {

        private readonly EshopDbContext dbContext;

        public EFProductRepository(EshopDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task Create(Product entity)
        {
            await dbContext.Products.AddAsync(entity);
            await dbContext.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var product = await dbContext.Products.SingleOrDefaultAsync(p => p.Id == id);
            dbContext.Products.Remove(product);
            await dbContext.SaveChangesAsync();

        }

        public IEnumerable<Product> GetAll()
        {
            return dbContext.Products.ToList();
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await dbContext.Products.ToListAsync();
        }

        public async Task<Product> GetById(int id)
        {
            return await dbContext.Products.FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<IEnumerable<Product>> GetProductsByCategoryIdAsync(int categoryId)
        {
            return await dbContext.Products.Where(p => p.CategoryId == categoryId).ToListAsync();
        }

        public IEnumerable<Product> GetProductsByName(string productName)
        {
            return dbContext.Products.Where(p => p.Name.Contains(productName)).ToList();
        }

        public async Task<IEnumerable<Product>> GetProductsByNameAsync(string productName)
        {
            return await dbContext.Products.Where(p => p.Name.Contains(productName)).ToListAsync();
        }

        public async Task Update(Product entity)
        {
            dbContext.Products.Update(entity);
            await dbContext.SaveChangesAsync();

        }
    }
}
