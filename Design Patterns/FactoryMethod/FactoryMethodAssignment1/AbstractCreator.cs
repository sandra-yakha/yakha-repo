using System;


namespace FactoryMethod
{
    public abstract class AbstractCreator
    {
        protected abstract Item ItemFactory();

        public Item HandOutItem()
        {
            Item item = ItemFactory();
            item.UseItem();
            return item;
        }
    }
}

