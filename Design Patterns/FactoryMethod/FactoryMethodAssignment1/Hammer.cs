using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Hammer : Item
    {
        public int attackValue { get; set; }

        public Hammer(string name, int iD, int attackValue) : base(name, iD)
        {
            this.attackValue = attackValue;
        }

        public override void UseItem()
        {
            Console.WriteLine($"You are attacking with the hammer {this.name}! Attack value: {this.attackValue}");
        }
    }
}
