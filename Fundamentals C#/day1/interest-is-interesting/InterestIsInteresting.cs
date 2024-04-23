using System;

static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
         if (balance < 0)
        {
            return 3.213f;
        }
        if (balance >= 0 && balance < 1000)
        {
            return 0.5f;
        }
        if (balance >= 1000 && balance < 5000)
        {
            return 1.621f;
        }
        else 
        {
        return 2.475f;
        }
    }

    public static decimal Interest(decimal balance)
    {
        return balance * (decimal)InterestRate(balance)/100;
    }

    public static decimal AnnualBalanceUpdate(decimal balance)
    {
        return balance + balance * (decimal)InterestRate(balance)/100;
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int years = 0;
        while (balance < targetBalance)
        {
            balance = AnnualBalanceUpdate(balance);
            years++;
        }
        return years;
    }
}
