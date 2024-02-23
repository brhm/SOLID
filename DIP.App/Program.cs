using DIP.App.Bad;
using good = DIP.App.Good;
// See https://aka.ms/new-console-template for more information

// dependency inversion princible.
// It is important, for unit-tests and maintainable.

// *** If I want to change the data repository. I have to change those codes and Product Service. 
// var productService = new ProductService(new ProductRepositoryFromOracle());
var productService = new ProductService(new ProductRepositoryFromSQLServer());
productService.GetAll().ForEach(p=> Console.WriteLine(p));

Console.WriteLine("------------------------------------------");

// if I want to change the data repository. I only need to change here.
//var _productService = new good.ProductService(new good.ProductRepositoryFromSQLServer());
var _productService = new good.ProductService(new good.ProductRepositoryFromOracle());
_productService.GetAll().ForEach(p => Console.WriteLine(p));



Console.ReadLine();
