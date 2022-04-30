using System;

namespace DDD_Domain_Events.Domain.Events
{
    public class ProductRegisteredEvent : IDomainEvent
    {
        public ProductRegisteredEvent(Guid productId, string productName)
        {
            ProductId = productId;
            ProductName = productName;
        }

        public Guid ProductId { get; set; }
        public string ProductName { get; set; }

    }
}
