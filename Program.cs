using System;

namespace Survey
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What Is Your Name?");
            var name = Console.ReadLine();

            Console.WriteLine("What Is Your Age?");
            var age = Console.ReadLine();

            Console.WriteLine("What Month Were You Born In?");
            var month = Console.ReadLine();

            Console.WriteLine("Your Name Is: {0}", name);
            Console.WriteLine("What Is Your Age: {0}", age);
            Console.WriteLine("What Month Were You Born In: {0}", month);

            if (month == "march")
            {
                Console.WriteLine("You Are a Aries.");
            }
            else if (month == "april")
            {
                Console.WriteLine("You Are a Taurus.");
            }
            else if (month == "may")
            {
                Console.WriteLine("You Are a Gemini.");

            }
        }
    }
}
