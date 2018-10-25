using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLab12
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Student("Jon Shaw", "24469 Republic Ave", 1, 40.00, "C#");
            Person person2 = new Student("Jon Snow", "Cold North", 0, 20000.00, "Nothing");
            Person person3 = new Student("Darius Rucker", "Cumberlad Gap", 3, 2000000.20, "Country Music");
            Person person4 = new Staff("Anna Beasley", "Unknown", "Grand Circus", 10000000.00);
            Person person5 = new Staff("Muhammed Mutahr", "Unknown", "Grand Circus", 10000000.00);

            Person[] peopleList = { person1, person2, person3, person4, person5 };

            foreach (Person i in peopleList)
            {
                Console.WriteLine(i.ToString());
                Console.WriteLine();
            }




        }
    }
}
