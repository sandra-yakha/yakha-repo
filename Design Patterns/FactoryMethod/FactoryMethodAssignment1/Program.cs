using System;

namespace FactoryMethod;
class Program
{
    public static void Main(string[] args)
    {
        AbstractCreator itemSoftware = new ItemCreator();
        Item myItem = itemSoftware.HandOutItem();
        Console.ReadKey();
    }
}