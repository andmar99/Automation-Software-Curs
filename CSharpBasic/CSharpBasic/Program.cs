using System;
namespace CSharpBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            //University university = new University();
            AddCourseList();
            Messages messages = new Messages();
            Console.WriteLine("Hello World!");
            messages.PrintMessages();
        }
        private static void AddCourseList()
        {
            var courses = new List<string>();
            courses.Add("Biology");
            courses.Add("Math");
            Console.WriteLine("Courses list ");
            foreach(string courseName in courses)
            {
                Console.WriteLine(courseName);
            }
        }
    }
    public static class University
    {
        public static void AboutUniversity()
        {
            Console.WriteLine("About university");
        }
    }
    public class Messages
    {
        public void PrintMessages()
        {
            int age;
            age = 25;
            bool student = false;

            Console.WriteLine("New Messages");
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();

            //If, else if, else
            if(student == true)
            {
                student = true;
                Console.WriteLine(name + " is a student");
            }
            else if (!(student == true))
            {
                Console.WriteLine(name + " isn't a student");
            }
            else
            {
                Console.WriteLine("Failed");
            }

            //While 
            Console.WriteLine("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());
            while (age < 18)
            {
                Console.WriteLine("Age " + age + " - " + name + " isn't a student");
                break;
            }
            while (age >= 18)
            {
                Console.WriteLine("Age " + age + " - " + name + "can be a student");
                break;
            }

            //For loop
            for (int i = 0; i <=5; i++)
            {
                Console.WriteLine("For loop condition number: " + i);
            }

            for(int i = 10; i > 5; i--)
            {
                Console.WriteLine("For loop condition number: " + i);
            }

            //Array
            string[] courses = { "Math", "Programming", "Biology" };
            int[] mathNotes = new int[3] { 7, 9, 6 };
            int[] programmingNotes = new int[3] { 10, 3, 8 };
            double[] biologyNotes = new double[5] { 9.2, 3.5, 8.0, 6.4, 5.9 };

            Console.WriteLine(name + "'s " + courses[0] + " notes are: " + mathNotes[0] + "," + mathNotes[1] + "," + mathNotes[2]);
            Console.WriteLine(name + "'s " + courses[1] + " notes are: " + programmingNotes[0] + "," + programmingNotes[1] + "," + programmingNotes[2]);
            Console.WriteLine(name + "'s " + courses[2] + " notes are: " + biologyNotes[0] + "," + biologyNotes[1] + "," + biologyNotes[2] + "," + biologyNotes[3] + "," + biologyNotes[4]);

            Console.WriteLine("Max biology note: " + biologyNotes.Max());
            Console.WriteLine("Min programming note: " + programmingNotes.Min());
            Console.WriteLine("Math average: " + mathNotes.Sum() / 3);
            Console.WriteLine("Biology average: " + biologyNotes.Sum() / 5);

            //Array Sort
            Array.Sort(biologyNotes);
            foreach (double arrayValue in biologyNotes)
                Console.WriteLine(arrayValue);

            Array.Sort(courses);
            foreach (string arrayValue in courses)
                Console.WriteLine(arrayValue);

            //Multidimensional arrays
            int[,] notes = { { 1, 3, 10 }, { 2, 4, 6 } };
            Console.WriteLine(notes[0 ,2]);
            notes[0, 0] = 5;
            Console.WriteLine(notes[0, 0]);
            foreach (int i in notes)
                Console.WriteLine("Array value " + i);

            //Get array length
            for(int i = 0; i < biologyNotes.GetLength(0); i++)
            {
                int j = biologyNotes.GetLength(0);
                Console.WriteLine("Biology notes array length: " + j);
                break;
            }

            int totalStudentNotes = 5;
            int[] note = new int[totalStudentNotes];
            for(int i = 0; i < totalStudentNotes; i++)
            {
                Console.WriteLine("Enter note: " + i);
                note[i] = Convert.ToInt32(Console.ReadLine());
            }

            //Reverse numbers
            Console.WriteLine("Reverse note list: ");
            Array.Reverse(mathNotes);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("{0}", mathNotes[i]);
            }


            var students = new List<string>() {"Mihai", "Cristina" };
            //Console.WriteLine(students); //incorect
            Console.WriteLine("Students list: ");
            foreach(string studentName in students)
            {
                Console.WriteLine(studentName);
            }
            students.Add("Mirela");
            students.Add("Andrei");
            Console.WriteLine("Students new list: ");
            foreach (string studentName in students)
            {
                Console.WriteLine(studentName);
            }

            var groupOfStudents = new List<int>() { 12, 28, 33 };
            Console.WriteLine("Total number of students: " + groupOfStudents.Sum());
            Console.WriteLine("Groups total: " + groupOfStudents.Count());

            //Try catch
            try
            {
                string[] studentsNames = { "Mihaela", "Ivan", "Alina" };
                Console.WriteLine(studentsNames[1]);
            }
            catch
            {
                Exception e;
                Console.WriteLine("\nSomething went wrong. The student doesn't exist.");
            }
        }
    }
}
