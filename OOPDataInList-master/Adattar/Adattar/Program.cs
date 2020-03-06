using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListakbanLevoAdatokKezeleseOOPalapokon
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Persons p = new Persons();
             List<Person> persons = p.getPersons();

             int N = persons.Count;
             //i-> ide kerül az aktuális legkisebb
             for (int i = 0; i < N - 1; i = i + 1)
             {
                 int min = persons[i].getAge();
                 int index = i;
                 // minimum keresés i..n-1
                 for (int j = i + 1; j < N; j++)
                 {
                     if (persons[j].getAge() < min)
                     {
                         min = persons[j].getAge();
                         index = j;
                     }
                 }
                 //csere
                 int temp = persons[i].getAge();
                 persons[i] = persons[index];
                 persons[index] = temp.Conve;
             }
             for (int i = 0; i < N; i++)
             {
                 Console.Write(persons[i] + ",");
             }
             

             * //Fej vagy írás játék tanári programja
             *FejVagyIrasKiserlet fik = new FejVagyIrasKiserlet();
            List<char> kiserletek = fik.getAdatok();

            int db = 0;
            int kezdoindex = 1;
            string minta = kiserletek[0].ToString() + kiserletek[1] + kiserletek[2];
            if (minta == "FFI")
            {
                db = db + 1;
                kezdoindex = 2;
                Console.WriteLine(minta);
            }
            int i = 0;
            for (i = kezdoindex; i <= kiserletek.Count-3; i++)
            {
                minta =
                    kiserletek[i - 1].ToString() + kiserletek[i] +
                    kiserletek[i + 1] + kiserletek[i + 2];
                if (minta == "IFFI")
                {
                    db = db + 1;
                    Console.WriteLine(minta+ " "+i);
                }
            }
            minta = kiserletek[i - 1].ToString() + kiserletek[i] + kiserletek[i + 1];
            if (minta == "IFF")
            {
                db = db + 1;
                Console.WriteLine(minta);
            }
            */

            FejVagyIrasKiserlet fik = new FejVagyIrasKiserlet();
            List<char> kiserletek = fik.getAdatok();

            /*
            int szamlalo = 0;
            int db = 0;
            foreach (char kiserlet in kiserletek)
            {
                if (kiserlet == 'F')
                {
                    db = db + 1;
                }
                else
                {
                    if (db == 3)
                    {
                        szamlalo = szamlalo + 1;
                    }
                    db = 0;
                }
            }
            Console.WriteLine(szamlalo);



            int max = 0;
            int ffdb = 0;
            foreach (char kiserlet in kiserletek)
            {
                if (kiserlet == 'F')
                {
                    ffdb = ffdb + 1;
                }
                else
                {
                    if (ffdb > max)
                    {
                        max = ffdb;
                    }
                    ffdb = 0;
                }
            }*/

            DiakAdatok da = new DiakAdatok();
            List<Diak> diakok = da.getAdatok();

            int fiukSzama = diakok.Count(x => x.getFerfi());
            List<Diak> fiuk = diakok.FindAll(x => x.getFerfi());
            List<Diak> lany = diakok.FindAll(x => x.getFerfi());
            int legmagasabblany = diakok.FindAll(x => x.getNo()).Max(x => x.getMagassag());
            int legmagasabbfiu = diakok.FindAll(x => x.getFerfi()).Max(x => x.getMagassag());
            string name = diakok.FindAll(x => x.getMagassag() == legmagasabblany).getNev();


            



            Console.ReadKey();
        }
    }
}
