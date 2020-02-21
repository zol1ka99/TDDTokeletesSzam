using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace StopwatchProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int>();
            Random rnd = new Random();
            int db = rnd.Next(99000, 100000);
            for (int b = 0; b < db; b++)
            {
                a.Add(rnd.Next(-99999, 99999));
            }

            int t = a[a.Count - 1];
            Console.WriteLine("Keresett elem: " + t);
            int n = a.Count;
            Console.WriteLine("Tömb elemeinek száma: " + n);
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            int i = 0;
            while ((i < n) && a[i] != t)
            {
                i++;
            }
            if (i < n)
            {
                Console.WriteLine(i);
            }
            else
            {
                Console.WriteLine(-1);
            }
            stopwatch.Start();
            int e = 0;
            int v = n - 1;
            int k = (e+v) / 2;
            while ((e<=v)&&(a[k]!=t))
            {
                if (a[k] > t)
                {
                    v = k - 1;
                }
                else
                {
                    e = k + 1;
                    k = (e + v) / 2;
                }
                if (a[k] == t)
                {
                    Console.WriteLine(k);
                }
                else
                {
                    Console.WriteLine(-1);
                }

                stopwatch.Stop();
                Console.WriteLine("Idő: " + stopwatch.Elapsed);
            }
        }
    }
}
