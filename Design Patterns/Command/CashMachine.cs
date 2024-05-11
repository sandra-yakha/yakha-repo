using System;
namespace CommandBankTransactions
{
    public class CashMachine
    {
        public void ExecuteBankTransaction(IBankTransactionCommand command)
        {
            command.Execute();
        }
    }
}

