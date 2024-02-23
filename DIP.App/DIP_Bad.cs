using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DIP.App.Bad
{
    public class ProductService
    {
        // High-level class (service) dependent on the low-level class.
        private readonly ProductRepositoryFromSQLServer _repository;
        public ProductService(ProductRepositoryFromSQLServer repository)
        {
                _repository = repository;
        }
        public List<string> GetAll()
        {
            return _repository.GetAll();
        }
    }

    public class ProductRepositoryFromSQLServer
    {
        public List<string> GetAll()
        {
            return new List<string> { "SQL Server Kalem", "SQL Server Defter", "SQL Server Kitap" };
        }
    }
}
