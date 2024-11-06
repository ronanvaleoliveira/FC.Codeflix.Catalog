using System.Collections.ObjectModel;

namespace FC.Codeflix.Catalog.Domain.SeedWork;

public abstract class AggregateRoot: Entity
{
    private readonly List<DomainEvent> _events = new();
    public IReadOnlyCollection<DomainEvent> Events
        => new ReadOnlyCollection<DomainEvent>(_events);

    public void RaiseEvent(DomainEvent @event) => _events.Add(@event);
    public void ClearEvents() => _events.Clear(); 
}