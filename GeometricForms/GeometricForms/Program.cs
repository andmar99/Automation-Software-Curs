using static OOP_Principles.Circle;
namespace OOP_Principles
{
    class Program
    {
        public static void Main(string[] args)
        {
            Circle circle = new Circle(2.3);
            Square square = new Square(3.1);
            Triangle triangle = new Triangle(4.5, 4.6);
            var area = circle.Area();
            var perimeter = circle.Perimeter();
            Console.WriteLine("Circle size: " + perimeter + "," + area);
            var areasq = square.Area();
            var perimetersq = square.Perimeter();
            Console.WriteLine("Square size: " + perimetersq + "," + areasq);
            var areatr = triangle.Area();
            Console.WriteLine("Triangle size: " + areatr);
        }
    }
    abstract class Form
    {
        public abstract double Area();
        public abstract double Perimeter();
    }
 class Circle : Form
    {
        public double radius;
        public Circle(double r)
        {
            radius = r;
        }
        public override double Area()
        {
            return 3.14159 * radius * radius;
        }
        public override double Perimeter()
        {
            return 2 * 3.14159 * radius;
        }
    }
    class Square : Form
    {
        public double side;
        public Square(double l)
        {
            side = l;
        }
        public override double Area()
        {
            return side * side;
        }
        public override double Perimeter()
        {
            return 4 * side;
        }
    }
   class Triangle : Form
    {
        public double ground;
        public double height;
        public Triangle(double g, double h)
        {
            ground = g;
            height = h;
        }

        public override double Area()
        {
            return 0.5 * ground * height;
        }

        public override double Perimeter()
        {
            throw new NotImplementedException();
        }
    }
}

