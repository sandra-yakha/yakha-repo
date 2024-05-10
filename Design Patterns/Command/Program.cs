namespace CommandBankTransactions;

class Program
{
    static void Main(string[] args)
    {
        BankAccount timoBA = new BankAccount();
        Console.WriteLine("Account was opened: " + timoBA.ToString());

        CashMachine cashMachineSC = new CashMachine();

        IBankTransactionCommand command1 = new DepositCommand(timoBA, 1000);
        IBankTransactionCommand command2 = new WithdrawCommand(timoBA, 500);
        IBankTransactionCommand command3 = new DepositCommand(timoBA, 1500);
        IBankTransactionCommand command4 = new UndoCommand(timoBA);
        IBankTransactionCommand command5 = new UndoCommand(timoBA);

        cashMachineSC.ExecuteBankTransaction(command1);
        cashMachineSC.ExecuteBankTransaction(command2);
        cashMachineSC.ExecuteBankTransaction(command3);
        cashMachineSC.ExecuteBankTransaction(command4);
        cashMachineSC.ExecuteBankTransaction(command5);


        Console.ReadKey();
    }
}
//Bankaccount->IbankTrans->Depo->With->Cash
