using DDD_Domain_Events.Domain.Events;
using DDD_Domain_Events.Domain.Handlers;
using SimpleInjector;

namespace DDD_Domain_Events.IoC.IoC
{
    public class Initializer
    {
        public static void RegisterServices(Container container)
        {
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
