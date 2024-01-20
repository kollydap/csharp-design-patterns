public class Cache
{
    // public Cache()
    // {
    //     this.CreateInstance();
    // }
    private static Cache cacheInstance;

    public Cache CreateInstance()
    {
        if (cacheInstance == null)
        {
            cacheInstance = new Cache();
        }
        return cacheInstance;
    }
}