using System;
namespace SingletonPattern
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            StandardInterestRate interestRate = StandardInterestRate.GetInstance();

            Console.WriteLine(interestRate);

        }
    }
}