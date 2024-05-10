using System;
namespace Mediator
{
    public interface IChatMediator
    {
        void SendMessage(string message, User user);

        void SendPrivateMessage(string message, User receiver, User sender);
        void AddUser(User user);
    }
}

