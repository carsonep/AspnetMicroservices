using Catalog.API.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.API.Data
{
    public class CatalogContext : ICatalogContext
    {
        public CatalogContext()
        {
            var client = new MongoClient
        }
        public IMongoCollection<Product> Products => throw new NotImplementedException();
    }
}
