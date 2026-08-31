using Repository2026_2.Data;
using Repository2026_2.Domain;
using Repository2026_2.Service;


ProductService oService = new ProductService(new ProductRepository());

List<Product> lp = oService.GetProducts();

if (lp.Count > 0)
    foreach (Product p in lp)
        Console.WriteLine(p);
else
    Console.WriteLine("No hay productos");