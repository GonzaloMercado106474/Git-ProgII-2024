using Repository2026_2.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository2026_2.Data
{
    public class ProductRepository : IProductRepository
    {
        public bool delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            List<Product> lst = new List<Product>();
          

            // conectar la base de datos 
           
            // Traer registros 

            var dt=DataHelper.GetInstance().ExecuteSPQuery("SP_Recuperar_Productos");
            //mapeamos

            foreach (DataRow row in dt.Rows)
            {
                Product p = new Product();
                p.Codigo = (int)row["codigo"];
                p.Nombre = (string)row["n_producto"];
                p.Precio = (double)row["precio"];
                p.Stock = (int)row["stock"];
                p.Activo = (bool)row["esta_activo"];
                lst.Add(p);

            }
            return lst;
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool save(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
