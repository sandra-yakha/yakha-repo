using System;
namespace CommandBankTransactions
{
    public interface IBankTransactionCommand
    {
        void Execute();
    }
}

