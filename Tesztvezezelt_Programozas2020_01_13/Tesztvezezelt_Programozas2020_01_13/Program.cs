using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tesztvezezelt_Programozas2020_01_13
{
    public class Program
    {

        public static bool IsEven(int number) //Megadja hogy a szám páros e// "szam" amiről eldöntjük hogy páros-e//return Igaz ha páros hamis ha páratlan
        {
            if(number%2==0)
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
