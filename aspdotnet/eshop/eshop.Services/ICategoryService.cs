using eshop.Services.DataTransferObjects.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop.Services
{
    public interface ICategoryService
    {
        Task<IList<CategoryMenuResponse>> GetCategories();
    }
}
