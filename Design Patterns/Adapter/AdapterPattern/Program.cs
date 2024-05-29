namespace AdapterMailServer;

class Program
{
    static void Main(string[] args)
    {
        GoogleMailServer server = new GoogleMailServer();
        AdapterServer adapterServer = new AdapterServer(server);

        adapterServer.ConnectAndSendEmail("hallo@mail.de", "Wie geht's?", "Raoul");
    }
}