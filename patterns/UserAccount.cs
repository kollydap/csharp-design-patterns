public abstract class UserAccount
{
    // public UserAccount(string name, int age)
    // {
    //     this.age = age;
    //     this.name = name;

    // }
    public string name { get; set; }
    public int age { get; set; }
    public Ipaymentmethod paymentmethod;
    public void MAkePAYMENT(int amount, int cardNumber)
    {
        this.paymentmethod.MakePayment(amount, cardNumber);
    }
}

public interface Ipaymentmethod
{
    public void MakePayment(int amount, int cardNumber);
}

public class StripePayment : Ipaymentmethod
{
    public void MakePayment(int amount, int cardNumber)
    {
        Console.WriteLine("Paying with Stripe...");
        if (amount < 1 || cardNumber.ToString().Length != 4)
        {
            return;
        }
        Thread.Sleep(10000);
        // Perdform other algorithms 
        Console.WriteLine("Successful");

    }
}

public class ZellePayment : Ipaymentmethod
{
    public void MakePayment(int amount, int cardNumber)
    {
        Console.WriteLine("Paying with Zelle...");
        if (amount < 1 || cardNumber.ToString().Length != 4)
        {
            return;
        }
        Thread.Sleep(10000);
        // Perdform other algorithms 
        Console.WriteLine("Successful");

    }
}

public class FreeUserAccount : UserAccount
{
    public FreeUserAccount(string name, int age)
    {
        this.name = name;
        this.age = age;
        this.paymentmethod = new ZellePayment();
    }
}