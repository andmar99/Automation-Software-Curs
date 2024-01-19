//Prototype Interface
interface IProtoType
{
    IProtoType Clone();
}
class Automobile : IProtoType
{
    public string Model { get; set; }
    public string Color { get; set; }
    public int DoorsNumber { get; set; }
    public Automobile(string model, string color, int doorsNumber)
    {
        Model = model;
        Color = color;
        DoorsNumber = doorsNumber;
    }
    //Implement Clone Method
    public IProtoType Clone()
    {
        return (IProtoType)MemberwiseClone();
    }
    class ProjectAutomobile
    {
        static void Main(string[] args)
        {
            Automobile prototype = new Automobile("Model x", "Black", 5);
            Automobile automobile1 = (Automobile)prototype.Clone();
            automobile1.Model = "Y";
            Automobile automobile2 = (Automobile)prototype.Clone();
            automobile2.Color = "White";
            Automobile automobile3= (Automobile)prototype.Clone();
            automobile3.DoorsNumber = 4;
            Console.WriteLine("Prototype: " + prototype.Model + ", " + prototype.Color + ", " + prototype.DoorsNumber);
            Console.WriteLine("Automobile 1: " + automobile1.Model + ", " + automobile1.Color + ", " + automobile1.DoorsNumber);
            Console.WriteLine("Automobile 2: " + automobile2.Model + ", " + automobile2.Color + ", " + automobile2.DoorsNumber);
            Console.WriteLine("Automobile 3: " + automobile3.Model + ", " + automobile3.Color + ", " + automobile3.DoorsNumber);

        }
    }
}
