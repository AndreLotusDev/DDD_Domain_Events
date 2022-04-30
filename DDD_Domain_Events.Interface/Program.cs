using DDD_Domain_Events.Domain.Entities;
using DDD_Domain_Events.Domain.Events;
using DDD_Domain_Events.IoC.IoC;
using SimpleInjector;
using System;

namespace DDD_Domain_Events.Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new Container();

            Initializer.RegisterServices(container);

            var newProductInSystem = new Product(Guid.NewGuid(), "TV 41 - 4K");

            var letTheSystemKnowAboutTheRegistering = new ProductRegisteredEvent(newProductInSystem.ProductId, newProductInSystem.NameOfProduct);

            Initializer.Raise(container, letTheSystemKnowAboutTheRegistering);

            Console.ReadKey();
        }
    }
}
