using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogaritmusosKeresés
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            List<int> a = new List<int>();
            int n = 1000;
            int e = 0;
            int v = n - 1;
            for (int i = 0; i < 1000; i++)
            {
                a.Add(rand.Next(1, 1000));
            }
            a.Sort();
            int kozep = (e + v) / 2;
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("A " + kozep + "számnál nagyobb vagy kisebb?");
                    if (Console.ReadLine()=="n")
                {
                    e = kozep;
                    kozep = (e = v) / 2;
                    i--;
                }
                    else
                {
                    v = kozep;
                    kozep = (kozep + e / 2);
                    i--;
                }
            }
            Console.ReadKey();
        }
    }
}
