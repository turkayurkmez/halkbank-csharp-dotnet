using eshop.DataAccess;
using eshop.Services.DataTransferObjects.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository repository;

        public CategoryService(ICategoryRepository repository)
        {
            this.repository = repository;
        }

        public async Task<IList<CategoryMenuResponse>> GetCategories()
        {
            var categories = await repository.GetAllAsync();
            return categories.Select(c => new CategoryMenuResponse { Id = c.Id, Name = c.Name }).ToList();
        }
    }
}
