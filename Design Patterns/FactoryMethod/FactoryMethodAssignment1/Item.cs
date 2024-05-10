using System;


namespace FactoryMethod
{
    public abstract class Item
    {
        public string name { get; set; }
        public int iD { get; set; }

        public Item(string name, int iD)
        {
            this.name = name;
            this.iD = iD;
        }

        public abstract void UseItem();
    }
}
