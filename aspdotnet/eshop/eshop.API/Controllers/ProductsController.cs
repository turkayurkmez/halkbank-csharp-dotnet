using Azure.Core;
using eshop.API.Filters;
using eshop.Services;
using eshop.Services.DataTransferObjects.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eshop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        private readonly IProductService productService;

        public ProductsController(IProductService productService)
        {
            this.productService = productService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]

        public async Task<IActionResult> GetAllProducts()
        {
            var products = await productService.GetProductsAsync();
            return Ok(products);
        }

        [HttpGet("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Get(int id)
        {
            var product = await productService.GetProductAsync(id);
            if (product != null)
            {
                return Ok(product);
            }
            return NotFound(new { message = $"{id} id'li ürün bulunamadı" });
        }
        [HttpGet("[action]/{name}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> Search(string name)
        {
            var products = await productService.SearchByName(name);
            if (products is not null)
            {
                return Ok(products);
            }

            return Ok(new { message = "Aradığınız kriterlere uygun bir ürün bulunamadı!" });
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Add(CreateProductRequest request)
        {
            if (ModelState.IsValid)
            {
                var createdProductId = await productService.CreateAsync(request);
                return CreatedAtAction(nameof(Get), routeValues: new { id = createdProductId }, null);
            }

            return BadRequest(ModelState);
        }
        [HttpPut("{id}")]
        [IsExisting]

        public async Task<IActionResult> Update(int id, UpdateProductRequest request)
        {

            if (id != request.Id)
            {
                return BadRequest(new { message = "endpoint'deki id ile request id farklı!" });
            }
            // var product = await productService.GetProductAsync(request.Id);

            //if (product is not null)
            //{
            if (ModelState.IsValid)
            {
                await productService.UpdateAsync(request);
                return Ok(new { message = $"{id} id'li ürün başarıyla güncellendi", incomingRequest = request });
            }
            return BadRequest(ModelState);
            //}
            //return BadRequest(new { message = "id hatalı!" });
        }
        [HttpDelete("{id}")]
        [IsExisting]
        public async Task<IActionResult> Delete(int id)
        {

            //var product = await productService.GetProductAsync(id);

            //if (product is not null)
            //{
            await productService.DeleteAsync(id);
            return Ok(new { message = $"{id} id'li ürün başarıyla silindi" });

            //}
            //return BadRequest(new { message = "id hatalı!" });
        }







    }
}
