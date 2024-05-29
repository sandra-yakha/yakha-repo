using System;
namespace CommandBankTransactions
{
    public class DepositCommand : IBankTransactionCommand
    {
        private BankAccount bankAccount;
        private double amount; //the deposit amount 


        public DepositCommand(BankAccount bankAccount, double amount) //constr
        {
            this.bankAccount = bankAccount;
            this.amount = amount;
        }


        public void Execute()
        {
            bankAccount.Deposit(amount);
        }
    }
}

