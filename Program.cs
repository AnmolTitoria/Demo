using System;
using System.Collections;
using System.Collections.Generic;


namespace Generic_non
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //for HashTable
            //Hashtable ht = new Hashtable();
            //ht.Add(1, 2);
            //ht.Add(3, 4);
            //ht.Add(5, "Hashtable1");
            //ht.Add("Hashtable2", 7);
            //ht.Add(7, 8);

            //foreach( DictionaryEntry fd in ht)
            //{
            //    Console.WriteLine("Key: {0}, Value:{1}" ,fd.Key, fd.Value);
            //}

            //for Dictonary(Generic) 

            IDictionary<int, string> Dicto= new Dictionary<int, string>();
            Dicto.Add(1, "One");
            Dicto.Add(2, "Two");
            Dicto.Add(5, "Five");
            //Dicto.Add("Six", 787); (Exception)

            foreach(var Dic in Dicto)
            {
                Console.WriteLine("Key: {0}, Value:{1}", Dic.Key, Dic.Value);
            }
        }
    }
}
