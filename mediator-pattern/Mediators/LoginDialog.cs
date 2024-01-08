using mediator_pattern.Components;

namespace mediator_pattern.Mediators;

public class LoginDialog : IMediator
{
    public Textbox Email { get; set; }
    public Textbox Password { get; set; }
    public Button Login { get; set; }

    public LoginDialog()
    {
        Email = new Textbox(this);
        Password = new Textbox(this);
        Login = new Button(this);
    }
    
    public void Notify(Component sender, string eventType)
    {
        if (sender.Equals(Login) && eventType == "click")
        {
            if (Email.Value == null! || Password.Value == null!)
            {
                Console.WriteLine("Please fill out your details first!");
            }
            else
            {
                Console.WriteLine($"Successfully logged in. Welcome {Email.Value}!");
            }
        }

        if (sender.Equals(Email))
        {
            Console.WriteLine("Successfully entered email.");
        }

        if (sender.Equals(Password))
        {
            Console.WriteLine("Successfully entered password.");
        }
    }
}