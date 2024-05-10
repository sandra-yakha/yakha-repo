using System;
using System.Threading.Channels;

namespace Iterator
{
    public class ChannelIteratorNormal : IChannelIterator
    {
        private List<Channel> channels;
        private int currentPosition = 0;

        public ChannelIteratorNormal(List<Channel> channels) //constructor
        {
            this.channels = channels;
        }


        public bool HasNext()
        {
            if (currentPosition < channels.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Channel Next()
        {
            return channels[currentPosition++]; 
        }
    }
}

