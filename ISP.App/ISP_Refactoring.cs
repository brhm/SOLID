using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP.App.Good
{
    /// <summary>
    ///  class library => Read imp
    ///  class library => Create/Update/Delete imp
    /// </summary>
    /// 

    // 1. Read Repository
    public class ReadRepository : IReadRepository
    {       
        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }
    }

    // 1. Write Repository
    public class WriteRepository : IWriteRepository
    {
        void IWriteRepository.Create(Product product)
        {
            throw new NotImplementedException();
        }

        void IWriteRepository.DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        void IWriteRepository.Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public interface IWriteRepository
    {
        void DeleteById(int id);
        void Update(Product product);
        void Create(Product product);
    }
    public interface IReadRepository
    {
        Product GetById(int id);
        List<Product> GetAll();

    }


}
