using System;
namespace Iterator
{
    public interface IChannelIterator
    {
        bool HasNext(); //bool
        Channel Next(); //return the channel
    }
}

