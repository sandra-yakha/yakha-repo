using System;
using System.Threading.Channels;

namespace Iterator
{
    public class CarRadio : IChannelCollection
    {
        private List<Channel> channels;
      
        public CarRadio()
        {
            this.channels = new List<Channel>();
        }

        public void AddChannel(Channel c)
        {
            channels.Add(c);
        }

        public IChannelIterator CreateIterator()
        {
            ChannelIteratorNormal iterator = new ChannelIteratorNormal(channels);
            return iterator;
        }

        public void RemoveChannel(Channel c)
        {
            channels.Remove(c);
        }

        public List<Channel> Shuffle()  // channels list is getting shuffeled permanently
        {
            int lastIndex = channels.Count - 1;
            while (lastIndex > 0)
            {
                Channel tmp = channels[lastIndex];
                int rand = new Random().Next(0, lastIndex);
                channels[lastIndex] = channels[rand];
                channels[rand] = tmp;
                lastIndex--;
            }
            List<Channel> shuffeledChannels;
            shuffeledChannels = channels;
            return  shuffeledChannels;
        }

    }
}

