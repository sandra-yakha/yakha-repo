using System;
namespace Mediator
{
    public abstract class User
    {
        public IChatMediator Mediator { get; set; } //so the User know where to sent the message to. 
        public string Name { get; set; }

        public User(string name, IChatMediator mediator)
        {
            Mediator = mediator;
            Name = name;
        }

        public abstract void SendMessage(string message);
        public abstract void SendPrivateMessage(string message, User receiver, User sender);
        public abstract void ReceiveMessage(string message);
        public abstract void ReceivePrivateMessage(string message, User sender);
    }
}