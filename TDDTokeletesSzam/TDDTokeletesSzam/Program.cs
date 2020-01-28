using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDTokeletesSzam
{
    public class Program
    {

        public bool TokeletesE(int szam)
        {
            return false;
        }

        public static int OsztokSzama(int szam)
        {
            if (szam == 0)
                throw new Exception("Nulla bemenet esetén osztók száma nem értelmezhető.");
            else if (szam < 0)
                szam = szam * -1;
            int osztokSzama = 0;
            for (int i = 1; i <= szam; i++)
            {
                if (szam % i == 0)
                    osztokSzama = osztokSzama + 1;
            }
            return osztokSzama;
        }


        public static bool tokeletesE(int szam)
        {
            return false;
        }

        static void Main(string[] args)
        {
        }
    }
}
