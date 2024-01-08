using mediator_pattern.Mediators;

namespace mediator_pattern.Components;

public class Button : Component
{
    public Button(IMediator mediator) : base(mediator)
    {
    }
    
    public void Click()
    {
        Dialog.Notify(this, "click");
    }
}