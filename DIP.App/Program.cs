using DIP.App.Bad;
// See https://aka.ms/new-console-template for more information

// dependency inversion princible.

var productService = new ProductService(new ProductRepositoryFromSQLServer());
productService.GetAll().ForEach(p=> Console.WriteLine(p));


Console.ReadLine();
