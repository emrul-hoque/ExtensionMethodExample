using System;

namespace ExtensionMethodExample
{
    static class Extension
    {
        public static string GetInfo (this Person person)
        {
            return "ID:\t\t"+ person.ID + ";\nName:\t\t" + person.Name + ";\nAddress:\t" + person.Address ;
        }
    }
}

