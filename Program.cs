using System;

namespace ExtensionMethodExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            Console.WriteLine("Enter the ID numbers: ");

            string[] id = new string[5];

            for (int i = 0; i < id.Length; i++)
            {
                id[i] = Console.ReadLine();
                person.ID = id[i];
            }

                       
            
            Console.WriteLine("Enter your name: ");
            var name = Console.ReadLine();
            person.Name = name;

            Console.WriteLine("Enter your address: ");
            var address = Console.ReadLine();
            person.Address = address;

            var info = person.GetInfo();
            Console.WriteLine(info);
            Console.Write("press any key ");
            Console.ReadKey();
        }
    }
}