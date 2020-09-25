using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Hashtable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hash = new Hashtable();
            hash.Add("1", "i love you");
            hash.Add("2", "你是谁");
            //hash.Remove("2");
            int n=hash.Count;
            hash.
            Console.WriteLine(n);
            //foreach (var item in hash.Keys)
            //{
            //    Console.WriteLine(item+" :"+hash[item]);
            //}
            foreach (DictionaryEntry item in hash)
            {
                Console.WriteLine(item.Key + ":" + item.Value);
            }
            Console.ReadKey();
        }
    }
}
