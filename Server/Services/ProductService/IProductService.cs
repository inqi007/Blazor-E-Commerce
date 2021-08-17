using E_commerce.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_commerce.Server.Services.ProductService
{
    public interface IProductService
    {
        Task<List<Product>> GetAllProducts();

        Task<List<Product>> GetProductsByCategory(string categoryUrl);

        Task<Product> GetProduct(int id);

        Task<List<Product>> SearchProducts(string searchText);
    }
}
