using System;
namespace Homework
{
    class Program
    {
        static void Main()
        {
            Student student = new Student();
            student.EnterStudentDetails();
            student.PrintStudentDetails();
        }
    }
    public class Student
    {
        string name;
        int age;
        double note1;
        double note2;
        double average;
        public void EnterStudentDetails()
        {
            Console.WriteLine("Enter student name: ");
            name = Console.ReadLine();

            Console.WriteLine("Enter student age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter first note: ");
            note1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second note: ");
            note2 = Convert.ToInt32(Console.ReadLine());

            average = (note1 + note2) / 2;
        }
        public void PrintStudentDetails()
        {
            Console.WriteLine("Student name: " + name);
            Console.WriteLine("Studnet age: " + age);
            Console.WriteLine("Student's first note: " + note1);
            Console.WriteLine("Student's second note: " + note2);
            Console.WriteLine("Average: " + average);
            if(average >= 6 && average <=10)
            {
                Console.WriteLine("Student passed");
            }
            else if (average >= 1 && average <=5)
            {
                Console.WriteLine("Student failed");
            }
            else
            {
                Console.WriteLine("Invalid note");
            }
        }
    }
}