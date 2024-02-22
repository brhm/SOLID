using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.App.Bad
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        private static List<Product> ProductList = new List<Product>();
        public static List<Product> GetProducts=> ProductList; // get property =>  GetProducts{ get{return ProductList;}}
        public Product()
        {
            ProductList = new()
            {
                new Product {Id=1,Name="Kalem 1"},
                new Product {Id=2,Name="Kalem 2"},
                new Product {Id=3,Name="Kalem 3"},
                new Product {Id=4,Name="Kalem 4"},
                new Product {Id=5,Name="Kalem 5"}
            };

        }
        public void SaveOrUpdate(Product product)
        {
            var hasProduct= ProductList.Any(p=>p.Id==product.Id);

            if(!hasProduct)
            {
                ProductList.Add(product);
            }
            else
            {
                var index= ProductList.FindIndex(p=>p.Id==product.Id);

                ProductList[index] = product;
            }
        }
        public void Detele(int  id)
        {
            var hasProduct=ProductList.Find(p=>p.Id==id);

            if(hasProduct==null) {

                throw new Exception($"{id} idli Ürün Bulunamadı");

            }

                ProductList.Remove(hasProduct);
        }
        public void WriteToConsole()
        {
            ProductList.ForEach(p =>
            {
                Console.WriteLine($"{p.Id} - {p.Name}");
            });
            Console.ReadLine();
        }

    }

}
