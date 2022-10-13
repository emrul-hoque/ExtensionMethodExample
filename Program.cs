using System;

namespace ExtensionMethodExample
{
    class Program
    {
        static void Main(string [] args)
        {
            Person person = new Person();

            person.ID = 101;
            person.Name = "Jabir";
            person.Address = "ACT, Australia";

            var info = person.GetInfo();
            Console.WriteLine(info);
            Console.ReadKey();
        }
    }
}