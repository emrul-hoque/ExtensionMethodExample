using System;

namespace ExtensionMethodExample
{
    class Program
    {
        static void Main(string [] args)
        {
            Person person = new Person();

            Console.WriteLine("Enter your ID number: ");
            int id = Convert.ToInt32(Console.Read());
            person.ID = id; //why is not showing the input from the user
            person.Name = "Jabir";
            person.Address = "ACT, Australia";

            var info = person.GetInfo();
            Console.WriteLine(info);
            Console.Write("press any key ");
            Console.ReadKey();
        }
    }
}