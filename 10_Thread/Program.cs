using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _10_Thread
{
    internal class Program
    {
        static List<string> isimler = new List<string> { "derya","ilker", "eren", "murat", "elif", "burak" };
        static int max = 10;
        static bool isStop = false;

        static void Main(string[] args)
        {
            Thread thread1 = new Thread(new ThreadStart(IsimleriYaz));
            Thread thread2 = new Thread(new ThreadStart(RastgeleSayilar));
            Thread thread3 = new Thread(Stop);
            //IsimleriYaz();
            //RastgeleSayilar();
            //Stop();

            thread1.Start();
            thread2.Start();
            thread3.Start();
        }

        static void Stop()
        {
            var a = Console.ReadKey();
            Console.WriteLine("Stop");
            isStop = true;
        }
        private static void RastgeleSayilar()
        {
            Random rnd = new Random();
            int ndx = 0;
            while (max != ndx)
            {
                if (isStop) break;
                ndx++;
                Console.WriteLine("Rand ==>" + rnd.Next());
                Thread.Sleep(300);
            }
        }

        private static void IsimleriYaz()
        {
            int ndx = 0;

            while (ndx != max)
            {
                if (isStop) break;
                ndx++;
                foreach (var item in isimler)
                {
                    Console.WriteLine("Name ==> " + item);
                    Thread.Sleep(200);
                }
            }
        }
    }
}
