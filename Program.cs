using System;
using System.Collections.Generic;

namespace KASDLab18
{
    internal class Program
    {
        static void Main()
        {
            MyHashMap<string, int> hashMap = new MyHashMap<string, int>();

            hashMap.Put("KASD", 4);

            Console.WriteLine(hashMap.Get("KASD"));

            Console.WriteLine(hashMap.ContainsKey("KASD"));
            Console.WriteLine(hashMap.ContainsKey("ASD"));

            hashMap.Put("KASD", 5);
            hashMap.Put("TEST", 5);
            hashMap.Put("DIFF", 5);

            foreach (var entry in hashMap.EntrySet())
            {
                Console.WriteLine("Key: {0}, Value: {1}", entry.Key, entry.Value);
            }

            Console.WriteLine(hashMap.IsEmpty());

            hashMap.Remove("TEST");

            foreach (var entry in hashMap.EntrySet())
            {
                Console.WriteLine("Key: {0}, Value: {1}", entry.Key, entry.Value);
            }

            HashSet<string> keySet = hashMap.KeySet();

            foreach (string key in keySet)
            {
                Console.WriteLine("Key: {0}", key);
            }

            Console.ReadKey();
        }
    }
}
