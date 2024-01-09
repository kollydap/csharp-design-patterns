public class Users
{

    public ISortUser sortUser;
    public string Name { get; set; }
    public int Id { get; set; }
    public int Level { get; set; }

    public void SortUser()
    {
        sortUser.Sort();
    }
    public Users()
    {

    }
}

public interface ISortUser
{
    public void Sort();
}

public class BubbleSort : ISortUser
{
    public void Sort()
    {
        Console.WriteLine("Perform BubbleSort !!!");

    }
}

public class BinarySort : ISortUser
{
    public void Sort()
    {
        Console.WriteLine("Perform BinarySort !!!");

    }
}

public class Student : Users
{
    public Student(string name, int Id, int level)
    {
        this.sortUser = new BinarySort();
        this.Level = level;
        this.Id = Id;
        this.Name = name;
    }


}

public class Teacher : Users
{
    public Teacher(string name, int Id, int level)
    {
        this.sortUser = new BubbleSort();
        this.Level = level;
        this.Id = Id;
        this.Name = name;
    }

    public void ChangeSortMethod(ISortUser sortUser)
    {
        this.sortUser = sortUser;

    }
}

