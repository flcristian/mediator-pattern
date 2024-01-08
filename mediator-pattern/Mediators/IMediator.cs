using mediator_pattern.Components;

namespace mediator_pattern.Mediators;

public interface IMediator
{
    void Notify(Component sender, string eventType);   
}