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
    public void MAkePAYMENT()
    {
        this.paymentmethod.MakePayment();
    }
}

public interface Ipaymentmethod
{
    public void MakePayment();
}

public class StripePayment : Ipaymentmethod
{
    public void MakePayment()
    {
        Console.WriteLine("PAying with Stripe");
    }
}

public class ZellePayment : Ipaymentmethod
{
    public void MakePayment()
    {
        Console.WriteLine("PAying with Zelle");
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