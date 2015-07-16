using System;

namespace NameSplitter
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ComputeName();

            do
            {
                while (!Console.KeyAvailable)
                {
                    ComputeName();
                }
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }

        private static void ComputeName()
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Please enter a name..");

            var name = Console.ReadLine();

            var personName = new PersonName(new NameSplitter(), name);
            Console.WriteLine("First Name is " + personName.GetFirstName());
            Console.WriteLine("Surname is " + personName.GetSurname());

            Console.WriteLine("-------------------------------");
            Console.Write("");
        }
    }
}
