using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP.App.Bad
{
    /// <summary>
    ///  class library => Read imp
    ///  class library => Create/Update/Delete imp
    /// </summary>
    /// 

    // 1. Read Repository
    public class ReadRepository : IProductRepository
    {
        // Create, DeleteById, Update functions are not necessary here. We have to avoid that. 
        // We will split the IProductRepository. That approach is the Interface Segregation Principle.
        public void Create(Product product)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public interface IProductRepository
    {
        Product GetById(int id);
        List<Product> GetAll();

        void DeleteById(int id);
        void Update(Product product);
        void Create(Product product);
    }


}
