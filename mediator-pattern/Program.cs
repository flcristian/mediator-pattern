using mediator_pattern.Components;
using mediator_pattern.Mediators;

internal class Program
{
    public static void Main(string[] args)
    {
        LoginDialog mediator = new LoginDialog();
        mediator.Email.Input("george@email.com");
        mediator.Login.Click();
        
        mediator.Password.Input("parola");
        mediator.Login.Click();
    }
}