using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository2026_2.Domain;


namespace Repository2026_2.Data
{
    public interface IProductRepository
    {
        List<Product> GetAll();
        Product GetById(int id);
        bool save(Product product);
        bool delete(int id);    
    }
}
