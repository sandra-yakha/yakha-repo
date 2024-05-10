using System.Threading.Channels;

namespace Iterator;

class Program
{
    static void Main(string[] args)
    {
        IChannelCollection radio = new CarRadio();
        radio.AddChannel(new Channel("FlyloFM", 106.4));
        radio.AddChannel(new Channel("Channel X", 103.1));
        radio.AddChannel(new Channel("The lab", 101.1));
        radio.AddChannel(new Channel("Reptile Radio", 98.7));

        IChannelIterator iterator = radio.CreateIterator(); //here we iterate through the car radio list without even to know how they are programmed or saved are 

        radio.Shuffle();
        while (iterator.HasNext())
        {
            Channel c = iterator.Next();
            Console.WriteLine(c);
        }
        Console.ReadKey();

    }
}

//IChannelIterator->IChannelCollection->Channel->

