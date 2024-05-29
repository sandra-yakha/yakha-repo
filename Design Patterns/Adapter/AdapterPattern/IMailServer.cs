using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterMailServer
{
    public interface IMailServer
    {
        void ConnectAndSendEmail(string emailAdress, string content, string receiverName);
    }
}
