using System;

namespace DDD_Domain_Events.Domain.Entities
{
    public class Product
    {
        public Product(Guid productId, string nameOfProduct)
        {
            ProductId = productId;
            NameOfProduct = nameOfProduct;
        }

        public Guid ProductId { get; set; }
        public string NameOfProduct { get; set; }
    }
}
