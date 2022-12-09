using System;

namespace MyNameSpase
{
    class MyClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter your name: ");     
            var name = Console.ReadLine();       //Ввести свое имя

            Console.Write("Enter your age: ");
            var age= Console.ReadLine();        //Ввести свой возраст

            Console.Write("Enter your date of birth: ");        //Ввести свою дату рождения
            var birthday = Console.ReadLine();

            Console.Write("What is your favorite day of week? ");
            DayOfWeek day = (DayOfWeek)int.Parse(Console.ReadLine());       //Ввести  свой любимый день недели

            Console.WriteLine("Your name is {0} and your is {1}", name, age);
            Console.WriteLine("Your birthday: {0}", birthday);
            Console.WriteLine("And your favorite day is {0}", day);
            Console.WriteLine("Nice to meet you and have a nice day :)");
        }
    }
}
