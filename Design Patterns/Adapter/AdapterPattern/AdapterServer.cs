using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterMailServer
{
    public class AdapterServer(GoogleMailServer server) : IMailServer
    {
        private GoogleMailServer googleMailServer = server;

        public void ConnectAndSendEmail(string emailAdress, string content, string receiverName)
        {
            googleMailServer.BuildConnection();
            Encryption();
            googleMailServer.SendEmail(receiverName, content);

            void Encryption()
            {
                Console.WriteLine("The e-mail has been encrypted.");
            }


        }
    }
}
