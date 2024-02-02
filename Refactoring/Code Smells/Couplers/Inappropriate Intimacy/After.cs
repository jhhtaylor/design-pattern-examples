public class Wallet
{
    private decimal money; // Encapsulated field

    public Wallet(decimal initialAmount)
    {
        money = initialAmount;
    }

    public bool SpendMoney(decimal amount)
    {
        if (money >= amount)
        {
            money -= amount;
            Console.WriteLine($"Spent {amount}, remaining {money}");
            return true;
        }
        else
        {
            Console.WriteLine("Not enough money");
            return false;
        }
    }

    // Optionally, provide a read-only property to check the balance without allowing direct modification
    public decimal Balance => money;
}

public class Person
{
    public Wallet Wallet { get; set; }

    public void SpendMoney(decimal amount)
    {
        if (!Wallet.SpendMoney(amount))
        {
            Console.WriteLine("Could not spend money");
        }
    }
}

public class Program
{
    public static void Main()
    {
        Person person = new Person { Wallet = new Wallet(100) };
        person.SpendMoney(50); // Spent 50, remaining 50
        person.SpendMoney(60); // Not enough money
    }
}