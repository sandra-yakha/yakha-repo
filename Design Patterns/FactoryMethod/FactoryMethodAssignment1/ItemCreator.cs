using System;


namespace FactoryMethod
{
    public class ItemCreator : AbstractCreator
    {
        protected override Item ItemFactory()
        {
            Item item = null;

            string[] itemsArray = { "shield", "hammer" };
            Random rand = new Random();
            int randomItem = rand.Next(itemsArray.Length);

            if (randomItem == 0)
            {
                item = new Shield("Carapax", 1, 20);
            }
            else
            {
                item = new Hammer("Frost Smasher", 2, 23);
            }

            return item;
        }

    }
}
