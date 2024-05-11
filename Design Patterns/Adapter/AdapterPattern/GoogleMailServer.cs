using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterMailServer
{
    public class GoogleMailServer
    {
        public GoogleMailServer()
        {

        }

        public void BuildConnection()
        {
            Console.WriteLine("Connection to the mail account established!");
        }

        public void SendEmail(string receiverEmail, string content)
        {
            Console.WriteLine("The mail was sent to " + receiverEmail + ".");
            Console.WriteLine("Content: " + content);
        }

    }
}
