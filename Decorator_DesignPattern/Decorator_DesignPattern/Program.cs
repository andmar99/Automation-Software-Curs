using static PizzaDecorator;
public interface Pizza
{
    string MakePizza();
}
public class PlainPizza : Pizza
{
    public string MakePizza()
    {
        return "Plain Pizza";
    }
}
public abstract class PizzaDecorator : Pizza
{
    protected Pizza pizza;
    public PizzaDecorator(Pizza pizza)
    {
        this.pizza = pizza;
    }
    public virtual string MakePizza()
    {
        return pizza.MakePizza();
    }
    public class ChickenPizzaDecorator : PizzaDecorator
    {
        public ChickenPizzaDecorator(Pizza pizza) : base(pizza) { }
        public override string MakePizza()
        {
            return pizza.MakePizza() + AddChicken();
        }
        private string AddChicken()
        {
            return ", Chicken added";
        }
    }
    public class VegPizzaDecorator : PizzaDecorator
    {
        public VegPizzaDecorator(Pizza pizza) :base(pizza) { }
        public override string MakePizza()
        {
            return pizza.MakePizza() + AddVegetables();
        }
        private string AddVegetables()
        {
            return ", Vegetables added";
        }
    }
}
class Program
{
    static void Main()
    {
        PlainPizza pizzaObj = new PlainPizza();
        string PlainPizza = pizzaObj.MakePizza();
        Console.WriteLine(PlainPizza);
        PizzaDecorator chickenPizzaDecorator = new ChickenPizzaDecorator(pizzaObj);
        string chickenPizza = chickenPizzaDecorator.MakePizza();
        Console.WriteLine("\n" + chickenPizza + " using ChichenPizzaDecorator");
        PizzaDecorator vegPizzaDecorator = new VegPizzaDecorator(pizzaObj);
        string vegPizza = vegPizzaDecorator.MakePizza();
        Console.WriteLine("\n" + vegPizza + " using VegPizzaDecorator");
    }
}
