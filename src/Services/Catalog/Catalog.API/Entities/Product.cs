using MongoDB.Bson.Serialization.Attributes;

namespace src.Services.Catalog.Catalog.API.Entities
{
    public class Product
    {
        [BsonId]
        public int Id { get; set; }
    }
}