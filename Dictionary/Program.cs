using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> plakalar = new Dictionary<int, string>();
            plakalar.Add(42, "Konya");
            plakalar.Add(34, "İstanbul");

            foreach (KeyValuePair<int, string> item in plakalar)
            {
                Console.WriteLine("{0} - {1}", item.Key, item.Value);
            }

            Console.WriteLine("Toplam Kayıt : " + plakalar.Count);
            Console.WriteLine();

            MyDictionary<int, string> plakalar2 = new MyDictionary<int, string>();
            plakalar2.Add(38, "Kayseri");

            foreach (var Keys in plakalar2.Keys)
            {
                Console.Write(Keys);
            }

            foreach (var Values in plakalar2.Values)
            {
                Console.WriteLine(" - " + Values);
            }

            Console.WriteLine("Toplam Kayıt : " + plakalar2.Count);

            Console.Read();
        }
    }
}
