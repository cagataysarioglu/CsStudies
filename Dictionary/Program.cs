using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(552, "The establishment of the khanate.");
            dictionary.Add(639, "The Kursad's revolution.");
            dictionary.Add(692, "The period of the Kapgan.");

            foreach (KeyValuePair<int, string> item in dictionary)
            {
                Console.WriteLine("{0} and {1}", item.Key, item.Value);
            }

            Console.WriteLine();

            dictionary.Remove(552);

            foreach (KeyValuePair<int, string> item in dictionary)
            {
                Console.WriteLine("{0} and {1}", item.Key, item.Value);
            }
            Console.WriteLine();

            dictionary.Clear();

            Console.WriteLine("The dictionary includes {0} key/value.", dictionary.Count);

        }
    }
}
