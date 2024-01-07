public abstract class Duck
{

    public IQuackBehavior quackBehavior;
    public IFlyBehavior flyBehavior;
    public abstract void display();


    //     Rather than handling the quack behavior
    // itself, the Duck object delegates that
    // behavior to the object referenced by
    // quackBehavior.
    // meaning : the object or instance calls the behavior itself instead of the Duck class
    // So any object that references any of the behavior will do the behaior itself
    // check page 15 chapter1
    public void PerformQuack()
    {
        quackBehavior.quack();
    }
    public void PerformFly()
    {
        flyBehavior.fly();
    }
}

public interface IQuackBehavior
{
    void quack();
}

public class Quack : IQuackBehavior
{
    public void quack()
    {
        Console.WriteLine("i QUACK ");
    }
}

public class Squeak : IQuackBehavior
{
    public void quack()
    {
        Console.WriteLine("i squeak ");
    }
}

public class MuteQuack : IQuackBehavior
{
    public void quack()
    {
        Console.WriteLine("i do not quack");
    }
}
public interface IFlyBehavior
{
    void fly();
}

public class FlyWithWings : IFlyBehavior
{
    public void fly()
    {
        Console.WriteLine("I am flying with Wings !!!!!");

    }
}

public class FlyWithTail : IFlyBehavior
{
    public void fly()
    {
        Console.WriteLine("I am flying with Tail !!!!!");

    }
}

public class DonotFly : IFlyBehavior
{
    public void fly()
    {
        Console.WriteLine("I cannot fly");

    }
}
public class MullardDuck : Duck
{
    public MullardDuck()
    {
        // the instance behavior set in the Duck class
        this.quackBehavior = new Quack();
        this.flyBehavior = new FlyWithWings();


    }
    public void ChangeQuackBehavior(IQuackBehavior quackBehavior)
    {
        this.quackBehavior = quackBehavior;
    }
    override public void display()
    {
        Console.WriteLine("I AM FINE");
    }
}

// We have interfaces
// we have classes that are behaviors or concrete implementations of that interface
// so the subclasses use those Behaviors 