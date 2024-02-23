using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DIP.App.Good
{
    public class ProductService
    {
        // The high-level class (service) has a loose coupling with the low-level class.
        // If we want to change the data repository. we don't touch here. We only need to change where the service call
        private readonly IRepository _repository;
        public ProductService(IRepository repository)
        {
                _repository = repository;
        }
        public List<string> GetAll()
        {
            return _repository.GetAll();
        }
    }

    public class ProductRepositoryFromSQLServer:IRepository
    {
        public List<string> GetAll()
        {
            return new List<string> { "SQL Server Kalem", "SQL Server Defter", "SQL Server Kitap" };
        }
    }
    public class ProductRepositoryFromOracle : IRepository
    {
        public List<string> GetAll()
        {
            return new List<string> { "Oracle Kalem", "Oracle Defter", "Oracle Kitap" };
        }
    }
    public interface IRepository
    {
        List<string> GetAll();
    }
}
