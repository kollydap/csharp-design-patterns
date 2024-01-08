

// ---------------------------------------------------------------------------------



public class WeatherData : ISubject
{
    float temperature;
    float pressure;
    float humidity;
    public WeatherData()
    {
        observersList = new List<IObserver>();

    }
    List<IObserver> observersList;
    public void RegisterObserver(IObserver o)
    {
        observersList.Add(o);
    }
    public void RemoveObserver(IObserver o)
    {
        if (observersList.Contains(o))
        {
            observersList.Remove(o);
            Console.WriteLine("Object removed successfully.");
        }
        else
        {
            Console.WriteLine("Object not found in the list.");
        }

    }


    public void NotifyObserver()
    {
        for (int i = 0; i < observersList.Count; i++)
        {
            observersList[i].Update(temperature, humidity, pressure);
        }

    }

    public void MeasurementChanged()
    {
        NotifyObserver();
    }

    public void SetMeasurements(float temperature, float humidity, float pressure)
    {
        this.temperature = temperature;
        this.humidity = humidity;
        this.pressure = pressure;
        this.MeasurementChanged();
    }

}

public class CurrentConditionDisplay : IObserver, IDisplayElement
{
    // we create a constructor ehre it subscribes to the Subject
    public CurrentConditionDisplay(ISubject subject)
    {
        this.subject = subject;
        subject.RegisterObserver(this);

    }
    float temperature;
    float humidity;
    ISubject subject;
    public void Update(float temperature, float humidity, float pressure)
    {
        this.temperature = temperature;
        this.humidity = humidity;
        this.Display();
    }
    public void Display()
    {
        Console.WriteLine("humidity is: " + this.humidity + "and temperature is: " + this.temperature);
    }
}