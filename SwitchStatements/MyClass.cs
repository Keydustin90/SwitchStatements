using System;
namespace SwitchStatements
{
    public class MyClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");

            var subject = Console.ReadLine();

            switch (subject)
            {
                case "Math":
                    Console.WriteLine("Math is Awesome!");
                    break;
                case "English":
                    Console.WriteLine("English is ok.");
                    break;
                case "Science":
                    Console.WriteLine("Science is also my favorite!");
                    break;
                case "Social Studies":
                    Console.WriteLine("Social Studies is cool!");
                    break;
                case "Art":
                    Console.WriteLine("Art is Awesome, its one of my favorite");
                    break;
                default:
                    Console.WriteLine("Ah I haven't taken that subject before");
                    break; 
            }
        }
    }
}
