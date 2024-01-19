public class Singleton
{
    private static Singleton singletonInstance;
    private Singleton()
    {

    }
    public static Singleton GetSingleton()
    {
        if (singletonInstance == null)
        {
            singletonInstance = new Singleton();
        }
        return singletonInstance;
    }
}