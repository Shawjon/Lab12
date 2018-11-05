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

            //List<ArchivedStudent> list = new List<ArchivedStudent>();
            //list.Add(new ArchivedStudent("Jon","Shaw", "FirstSpot", 1, 20, "C#", 100));
            //list.Add(new ArchivedStudent("Zon","Ahaw", "SecondSpot", 1, 20, "C#", 0));
            //list.Add(new ArchivedStudent("Yon", "Bhaw", "ThirdSpot", 1, 20, "C#", 50));
            //list.Add(new ArchivedStudent("Bon", "Chaw", "FourthSpot", 1, 20, "C#", 50));
            //list.Add(new ArchivedStudent("Aon", "Zhaw", "FifthSpot", 1, 20, "C#", 75));
            //list.Add(new ArchivedStudent("test", "tester", "sixthSpot", 2, 31, "test", 20));
                                   
            //list.Sort();
                        
            //foreach (var element in list)
            //{
            //    Console.WriteLine(element);
            //}
            //Console.ReadKey();

            Student person1 = new Student("Jon", "Shaw", "24469 Republic Ave", 1, 40.00, "C#");
            Student person2 = new Student("Jon", "Snow", "Cold North", 0, 2.60, "Nothing");
            Student person3 = new Student("Darius", "Rucker", "Cumberlad Gap", 3, 30.30, "Country Music");
            //Person person4 = new Staff("Anna Beasley", "Unknown", "Grand Circus", 10000000.00);
            //Person person5 = new Staff("Muhammed Mutahr", "Unknown", "Grand Circus", 10000000.00);

            List<Student> peopleList = new List<Student>{ person1, person2, person3, };
            peopleList.Add(new ArchivedStudent("Bon","Chaw", "FourthSpot", 1, 20, "C#", 50));
            peopleList.Add(new ArchivedStudent("Aon","Zhaw", "FifthSpot", 1, 20, "C#", 75));

            Student.ToList(peopleList);
            Console.ReadKey();
            peopleList.Sort();

            foreach (Student i in peopleList)
            {
                Console.WriteLine(i.ToString());
                
            }




        }
    }
}
