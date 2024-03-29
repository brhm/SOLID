﻿using System;
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
        // The high-level class (service) has a high coupling with the low-level class.

        // *** If I want to change the data repository. I have to change those codes.
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
    // when I want to change the data repository, I have to change the service and where the service call.(Program cs)
    public class ProductRepositoryFromOracle
    {
        public List<string> GetAll()
        {
            return new List<string> { "Oracle Kalem", "Oracle Defter", "Oracle Kitap" };
        }
    }
}
