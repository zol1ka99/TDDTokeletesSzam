using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValosSzam
{
    public struct Kor
    {
        public int x;
        public int y;
        public int r;
    }
    public struct Pont
    {
        public int a;
        public int b;
    }
    public class Program
    {
        public static bool KorlemezVanE(Pont p, Kor k)
        {
            if (Math.Pow((k.x - p.a), 2) + Math.Pow((k.y - p.b), 2) <= Math.Pow(k.r, 2))
            {
                return true;
            } else
            {
                return false;
            }
        }


        static void Main(string[] args)
        {
            
        }
    }
}


