using mediator_pattern.Mediators;

namespace mediator_pattern.Components;

public class Textbox : Component
{
    public String Value { get; set; }


    public Textbox(IMediator mediator) : base(mediator)
    {
        Value = null!;
    }

    public void Input(String value)
    {
        Value = value;
        Dialog.Notify(this, "input");
    }
}