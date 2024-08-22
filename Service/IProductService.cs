using DemoMvcApp.Models;

namespace DemoMvcApp.Service
{
    public interface IProductService
    {
     
        Product GetProductById(int id);
    }
}
