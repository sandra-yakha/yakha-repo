using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class StandardInterestRate
    {
        private static readonly StandardInterestRate instance = new StandardInterestRate();

        public decimal interestRate = 0.03M;

        private StandardInterestRate()
        {
            Console.WriteLine("The Singleton was created.");
        }

        public static StandardInterestRate GetInstance()
        {
            return instance;
        }

        public override string ToString()
        {
            return $"The standard interest rate is at {interestRate * 100}%";
        }
    }
}
