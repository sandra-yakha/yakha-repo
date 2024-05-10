using System;
namespace Mediator
{
    class ChatMediatorImpl : IChatMediator
    {
        private List<User> userList; // a list of users so the Mediator can communicate (and reference the users) with them for example when a new user joins the chat or leaves

    public ChatMediatorImpl()
    {
        userList = new List<User>();
    }

    public void AddUser(User user)
    {
        userList.Add(user); //we add a user to the list
    }

    public void SendMessage(string message, User user) //this is the user who sends a message.
    {
        foreach (User u in userList)
        {
            // Ensure the user does not receive their own message
            if (u != user)
            {
                u.ReceiveMessage(message);
            }
        }
    }

    public void SendPrivateMessage(string message, User receiver, User sender)
        { 
            receiver.ReceivePrivateMessage(message, sender);
        }
}
}

