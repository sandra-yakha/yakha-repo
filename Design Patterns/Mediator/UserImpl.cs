using System;
namespace Mediator
{
    public class UserImpl : User
    {
        public UserImpl(string name, IChatMediator mediator) : base(name, mediator) { }

        public override void ReceiveMessage(string message)
        {
            Console.WriteLine(Name + " has received a message"); 
            Console.WriteLine(Name + ": " + message);
        }

        public override void SendMessage(string message)
        {
            Console.WriteLine(Name + ": " + message);
            Mediator.SendMessage(message, this);
        }

        public override void SendPrivateMessage(string message, User receiver, User sender)
        {
            Console.WriteLine($"{Name} has sent \"{message}\" to {receiver.Name}");
            Mediator.SendPrivateMessage(message, receiver, sender);
        }

        public override void ReceivePrivateMessage(string message, User sender)
        {
            Console.WriteLine($"{Name} has received the message \"{message}\" by {sender.Name}");
            
        }
    }
}

