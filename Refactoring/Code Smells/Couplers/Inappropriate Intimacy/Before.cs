public class Wallet
{
    public decimal Money { get; set; }

    public Wallet(decimal initialAmount)
    {
        Money = initialAmount;
    }
}

public class Person
{
    public Wallet Wallet { get; set; }

    public void SpendMoney(decimal amount)
    {
        if (Wallet.Money >= amount)
        {
            Wallet.Money -= amount; // Directly accessing and modifying Wallet's internals
            Console.WriteLine($"Spent {amount}, remaining {Wallet.Money}");
        }
        else
        {
            Console.WriteLine("Not enough money");
        }
    }
}
