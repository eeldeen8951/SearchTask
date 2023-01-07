using Applocation.ProductManager;
using Microsoft.AspNetCore.Mvc;
using Shared.SearchDTO;

namespace SearchTask.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class ProductsController : ControllerBase
    {
        IProductManager productManager;
        public ProductsController(IProductManager productManager)
        {
            this.productManager = productManager;
        }


        [HttpGet]
        public List<ProductDTO> productSearch(string product) => productManager.productSearch(product);
    }
}