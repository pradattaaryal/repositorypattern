 
using DemoMvcApp.Models;
using DemoMvcApp.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace DemoMvcApp.Service
{
    
    public class ProductService : IProductService
    {
        private readonly IProductRepository _IProductRepository;

        public ProductService(IProductRepository x)
        {
            _IProductRepository = x;
        }


        

        public Product GetProductById(int id)
        {
         return _IProductRepository.GetProductById(id);
 
        }
    }
}
