using System;

namespace ExtensionMethodExample
{
    static class Extension
    {
        public static string GetInfo (this Person person)
        {
            return "ID "+ person.ID + "; Name: " + person.Name + "; Address: " + person.Address ;
        }
    }
}

