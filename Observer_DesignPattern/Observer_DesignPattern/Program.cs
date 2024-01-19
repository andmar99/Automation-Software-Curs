using System;
//This interface is for observers
interface IObserver
{
    void Update(string message);
}
//Subject interface
interface ISubject
{
    void RegisterObserver(IObserver observer);
    void RemoveObserver(IObserver observer);
    void NotifyObservers();
}
//Observers class
class Users : IObserver
{
    private string name;
    public Users(string name)
    {
        this.name = name;
    }
    public void Update(string message)
    {
        Console.WriteLine(name + " receved a message: " + message);
    }
}
//This class is for subject
class SocialApp : ISubject
{
    private List<IObserver> users = new List<IObserver>();
    private string message;
    public void NotifyObservers()
    {
        foreach(IObserver observer in users)
        {
            observer.Update(message);
        }
    }
    public void RegisterObserver(IObserver observer)
    {
        users.Add(observer);
    }
    public void RemoveObserver(IObserver observer)
    {
        users.Remove(observer);
    }
    public void PublicMessage(string message)
    {
        this.message = message;
        NotifyObservers();
    }
}
class Program
{
    static void Main(string[] args)
    {
        SocialApp app = new SocialApp();
        Users user1 = new Users("Ion");
        Users user2 = new Users("Maria");
        Users user3 = new Users("Vasile");
        app.RegisterObserver(user1);
        app.RegisterObserver(user2);
        app.PublicMessage("Hello all");
        app.RemoveObserver(user1);
        app.PublicMessage("Someone online?");
    }
}