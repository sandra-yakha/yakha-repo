using System;
namespace CommandBankTransactions
{
    public class BankAccount
    {
        public double Balance { get; set; } = 0;
        public double OverdraftLimit { get; set; } = 1000;

        private List<double> deposits = new List<double>(); // stores deposits

        public void Deposit(double amount)
        {
            Balance += amount;
            Console.WriteLine($"{amount} Euros have been deposited into the account.");
            deposits.Add(amount);
        }

        public void Withdraw(double amount)
        {
            if (Balance - amount >= -OverdraftLimit)
            {
                Balance -= amount;
                Console.WriteLine($"{amount} Euros have been withdrawn from the account. The new balance is {Balance} Euros.");
            }
            else
            {
                Console.WriteLine($"Unable to withdraw this amount: Your overdraft limit is set to {OverdraftLimit} Euros.");
            }

        }

        public void Undo()
        {
            Balance -= deposits.Last();
            Console.WriteLine($"Last deposit of {deposits.Last()} Euros undone. The new balance is {Balance} Euros.");
            deposits.Remove(deposits.Last());
        }

        public override string ToString()
        {
            return $"Account balance: {Balance} Euros, Overdraft limit: {OverdraftLimit} Euros";
        }


    }
}

