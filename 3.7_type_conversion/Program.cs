using System;

namespace MyNameSpase
{
    class MyClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter your name: ");     
            string name = Console.ReadLine();       //Ввести свое имя

            Console.Write("Enter your age: ");
            int age= checked ((byte) int.Parse(Console.ReadLine()));        //Ввести свой возраст

            Console.Write("What is your favorite day of week? ");
            DayOfWeek day = (DayOfWeek)int.Parse(Console.ReadLine());       //Ввести  свой любимый день недели

            Console.WriteLine("Your name is {0} and your is {1}", name, age);
            
            Console.WriteLine("Your favorite day is {0}", day);
        }
    }
}
