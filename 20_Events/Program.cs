using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Events
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Words words = new Words();
            words.OnWordRemoved += Words_OnWordRemoved;
            words.OnWordRemoved += Words_OnWordRemoved_Management;
            words.OnWordAdded += Words_OnWordAdded;

            words.Add("Carbon");
           
            words.ListAll();
            Console.WriteLine("---------------------------------");
            words.Add("Rust");
            words.ListAll();
        }

        private static void Words_OnWordAdded(WordAddedEventArgs args)
        {
            Console.WriteLine(args.Word+" Kelime eklendi");
            Console.WriteLine(args.Items.Count + " Kelime var");
            Console.WriteLine(args.AddedDateTime);
            Console.WriteLine();
        }

        private static void Words_OnWordRemoved_Management()
        {
            Console.WriteLine("Yönetime bilgi verildi"); ;
        }

        private static void Words_OnWordRemoved()
        {
            Console.WriteLine("Kelime Çıkarıldı"); ;
        }
    }
}
