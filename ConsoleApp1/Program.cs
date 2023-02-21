using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<int, string> koolid = new Dictionary<int, string>();

        koolid.Add(1, "Nõmme gümnaasium");
        koolid.Add(2, "TTHK");
        koolid.Add(3, "Rahumäe põhikool");
        

        foreach (KeyValuePair<int, string> kool in koolid)
        {
            Console.WriteLine("kooli number {0} nimi on {1}.", kool.Key, kool.Value);
        }

        Console.ReadLine();
    }
}