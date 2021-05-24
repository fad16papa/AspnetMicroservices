using System;
using MongoDB.Driver;
using Catalog.API.Entities;

namespace Catalog.API.Data
{
    public interface ICatalogInterface
    {
       IMongoCollection<Product> Products { get; }
    }
}
