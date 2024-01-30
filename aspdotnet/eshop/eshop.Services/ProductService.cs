using eshop.DataAccess;
using eshop.Entities;
using eshop.Services.DataTransferObjects.Request;
using eshop.Services.DataTransferObjects.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository repository;

        public ProductService(IProductRepository repository)
        {
            this.repository = repository;
        }

        public async Task<int> CreateAsync(CreateProductRequest request)
        {
            var product = new Product()
            {
                CategoryId = request.CategoryId,
                Name = request.Name,
                Description = request.Description,
                ImageUrl = request.ImageUrl,
                Price = request.Price,
                Stock = request.Stock,
            };
            await repository.Create(product);
            return product.Id;
        }

        public async Task DeleteAsync(int id)
        {
            await repository.Delete(id);
        }

        public async Task<ProductDisplayResponse> GetProductAsync(int id)
        {
            var product = await repository.GetById(id);
            var response = new ProductDisplayResponse()
            {
                CategoryId = product.CategoryId,
                Name = product.Name,
                Description = product.Description,
                ImageUrl = product.ImageUrl,
                Id = product.Id,
                Price = product.Price,
            };

            return response;

        }

        public IEnumerable<Product> GetProducts()
        {
            IEnumerable<Product> products = repository.GetAll();
            return products;
        }

        public async Task<IEnumerable<ProductDisplayResponse>> GetProductsAsync()
        {
            var products = await repository.GetAllAsync();
            var response = products.Select(p => new ProductDisplayResponse()
            {
                CategoryId = p.CategoryId,
                Name = p.Name,
                Description = p.Description,
                ImageUrl = p.ImageUrl,
                Id = p.Id,
            });
            return response;
        }

        public async Task<IEnumerable<ProductDisplayResponse>> GetProductsByCategoryIdAsync(int categoryId)
        {
            var products = await repository.GetProductsByCategoryIdAsync(categoryId);
            var response = products.Select(p => new ProductDisplayResponse()
            {
                CategoryId = p.CategoryId,
                Name = p.Name,
                Description = p.Description,
                ImageUrl = p.ImageUrl,
                Id = p.Id

            });
            return response;
        }

        public async Task<IEnumerable<ProductDisplayResponse>> SearchByName(string name)
        {
            var products = await repository.GetProductsByNameAsync(name);
            var response = products.Select(p => new ProductDisplayResponse()
            {
                CategoryId = p.CategoryId,
                Name = p.Name,
                Description = p.Description,
                ImageUrl = p.ImageUrl,
                Id = p.Id

            });
            return response;
        }

        public async Task<int> UpdateAsync(UpdateProductRequest request)
        {
            var product = new Product
            {
                CategoryId = request.CategoryId,
                Name = request.Name,
                Description = request.Description,
                ImageUrl = request.ImageUrl,
                Id = request.Id,

            };

            await repository.Update(product);
            return product.Id;
        }
    }
}
