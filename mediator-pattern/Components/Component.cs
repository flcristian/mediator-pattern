using mediator_pattern.Mediators;

namespace mediator_pattern.Components;

public abstract class Component
{
    protected IMediator Dialog { get; set; }

    protected Component(IMediator mediator)
    {
        Dialog = mediator;
    }
}

