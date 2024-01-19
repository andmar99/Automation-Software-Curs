namespace OOP_Principles
{
    class Program
    {
        public static void Main() 
        {
            Cat cat = new Cat();
            Dog dog = new Dog();
            Bird bird= new Bird();

            cat.AboutCat();
            cat.AnimalPlay();
            cat.AnimalRun();
            dog.AboutDog();
            dog.AnimalRun();
            dog.AnimalPlay();
            dog.Name = "Max";
            dog.AnimalRun(2);
            dog.AnimalRun("Max", 2);
            Console.WriteLine("Dog name is: " + dog.Name);
            bird.AboutWingsColor();
            bird.WingsSize(2.7);
            bird.AnimalFly();
        }
    }
}
