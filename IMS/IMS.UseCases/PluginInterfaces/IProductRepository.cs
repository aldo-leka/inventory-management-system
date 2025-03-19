using IMS.CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.UseCases.PluginInterfaces
{
    public interface IProductRepository
    {
        Task AddProductAsync(Product inventory);
        Task DeleteProductByIdAsync(int inventoryId);
        Task<IEnumerable<Product>> GetProductsByNameAsync(string name);
        Task<Product> GetProductByIdAsync(int inventoryId);
        Task UpdateProductAsync(Product inventory);
    }
}
