using Shared.SearchDTO;

namespace Applocation.ProductManager
{
    public interface IProductManager
    {
        List<ProductDTO> productSearch(string product);
    }
}