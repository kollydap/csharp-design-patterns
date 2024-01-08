public class PublishingCompany : INewsSubject
{
    string paperName;
    int id;
    public PublishingCompany()
    {
        observersList = new List<INewsObserver>();

    }
    List<INewsObserver> observersList;
    public void RegisterObserver(INewsObserver o)
    {
        observersList.Add(o);
    }
    public void RemoveObserver(INewsObserver o)
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
    public void UpdateData(string paperName, int id)
    {
        this.id = id;
        this.paperName = paperName;
        this.DataChanged();
    }

    public void NotifyObserver()
    {
        for (int i = 0; i < observersList.Count; i++)
        {
            observersList[i].Update(paperName, id);
        }

    }

    public void DataChanged()
    {
        NotifyObserver();

    }

}

class PunchNewsPaper : INewsObserver
{

    public void Update(string paperName, int id)
    {

    }

}