using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable numberNames = new Hashtable();
            numberNames.Add(1, "Seven");
            numberNames.Add(2, "Eight");
            numberNames.Add(3, "Nine");
            foreach(DictionaryEntry de in numberNames)
                Console.WriteLine("Key: {0}, Value: {1}", de.Key, de.Value);
            Console.ReadLine();
        }
    }
}
