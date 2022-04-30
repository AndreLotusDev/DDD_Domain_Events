using DDD_Domain_Events.Domain.Events;
using System;

namespace DDD_Domain_Events.Domain.Handlers
{
    public class ProductSaveHandle : IHandler<ProductRegisteredEvent>
    {
        public void Handle(ProductRegisteredEvent args)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"New product registered, more information: ID: {args.ProductId} | Name: {args.ProductName}");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
