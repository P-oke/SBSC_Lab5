using System;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            BankA bankA = new BankA();
            bankA.getBalance();

            BankB bankB = new BankB();
            bankB.getBalance();

            BankC bankC = new BankC();
            bankC.getBalance();

        }
    }
}

public abstract class Bank
{
    public decimal Bank_A = 100;
    public abstract void getBalance();

}

public class BankA : Bank
{
    private double depositedAmount = 100;

    public override void getBalance()
    {
        Console.WriteLine($"Balance in BankA is: ${depositedAmount}");
    }

}

public class BankB : Bank
{
    private double depositedAmount = 150;
    public override void getBalance()
    {
        Console.WriteLine($"Balance in BankB is ${depositedAmount}");
    }


}
public class BankC : Bank
{
    private double depositedAmount = 200;
    public override void getBalance()
    {
        Console.WriteLine($"Balance in BankC is: ${depositedAmount}");
    }


}