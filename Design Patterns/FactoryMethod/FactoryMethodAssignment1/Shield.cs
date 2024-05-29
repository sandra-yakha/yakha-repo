using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FactoryMethod
{
    public class Shield : Item
    {
        public int defenseValue { get; set; }

        public Shield(string name, int iD, int defenseValue) : base(name, iD)
        {
            this.defenseValue = defenseValue;
        }
        public override void UseItem()
        {
            Console.WriteLine($"You defend yourself with the shield {this.name}! Defense value: {this.defenseValue}");
        }
    }
}
