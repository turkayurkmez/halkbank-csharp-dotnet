using eshop.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace eshop.API.Filters
{
    public class IsExistsFilter : IAsyncActionFilter
    {
        private readonly IProductService productService;

        public IsExistsFilter(IProductService productService)
        {
            this.productService = productService;
        }

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var id = (int)context.ActionArguments["id"];
            var product = await productService.GetProductAsync(id);

            if (product != null)
            {
                await next();
            }

            context.Result = new BadRequestResult();

        }
    }
}
