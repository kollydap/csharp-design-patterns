public interface ISubject
{
    public void RegisterObserver(IObserver o);
    public void RemoveObserver(IObserver o);

    public void NotifyObserver();
}

public interface IObserver
{
    public void Update(float temperature, float humidity, float pressure);
}
public interface IDisplayElement
{
    public void Display();
}


public interface INewsSubject
{
    public void RegisterObserver(INewsObserver o);
    public void RemoveObserver(INewsObserver o);

    public void NotifyObserver();
}

public interface INewsObserver
{
    public void Update(string paperName, int id);
    
}


