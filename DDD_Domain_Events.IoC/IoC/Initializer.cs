using DDD_Domain_Events.Domain.Events;
using DDD_Domain_Events.Domain.Handlers;
using SimpleInjector;
using System;
using System.Linq;

namespace DDD_Domain_Events.IoC.IoC
{
    public class Initializer
    {
        public static void RegisterServices(Container container)
        {
            //var typeOfDomainEvent = typeof(IDomainEvent);
            //var assembly = typeof(IDomainEvent).Assembly;

            //var checkIfAreNotAnInterfaceType = new Func<Type, bool>(t => typeOfDomainEvent.IsAssignableFrom(t) && t.IsClass && !t.IsAbstract);
            //var typesOfIHandler = assembly.GetTypes().ToList().Where(t => checkIfAreNotAnInterfaceType(t));

            //container.Register(typeof(IHandler<>), typesOfIHandler);

            container.Collection.Register(typeof(IHandler<>), typeof(IDomainEvent).Assembly);
        }

        public static void Raise<TEventEntity>(Container container, TEventEntity eventEntity) where TEventEntity : IDomainEvent
        {
            var handles = container.GetAllInstances<IHandler<TEventEntity>>();

            foreach (var handler in handles)
            {
                handler.Handle(eventEntity);
            }
        }
    }
}
