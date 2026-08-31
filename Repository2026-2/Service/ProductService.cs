using Repository2026_2.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository2026_2.Domain;
namespace Repository2026_2.Service
{
    public class ProductService 
    {
        private IProductRepository _repository;
        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }
        public List<Product> GetProducts()
        {
            return _repository.GetAll();
        }
        public bool SaveProduct(Product product)
        {
            return _repository.save(product);
        }
    }
}
