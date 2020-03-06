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
            Persons p = new Persons();
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
            Console.ReadKey();
        }
    }
}
