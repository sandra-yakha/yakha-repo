using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandBankTransactions
{
    public class UndoCommand : IBankTransactionCommand
    {
        private BankAccount bankAccount;

        public UndoCommand(BankAccount bankAccount)
        {
            this.bankAccount = bankAccount;
        }

        public void Execute()
        {
            bankAccount.Undo();
        }
    }
}
