using DDD_Domain_Events.Domain.Events;

namespace DDD_Domain_Events.Domain.Handlers
{
    public interface IHandler<in TEventEntity> where TEventEntity : IDomainEvent
    {
        void Handle(TEventEntity args);
    }
}
