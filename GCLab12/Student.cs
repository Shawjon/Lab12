using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLab12
{
    public class Student:Person,People,IComparable<Student>
    {
        #region Data
        private int Year;
        private double Fee;
        private string Program;
        #endregion
        #region Constructor
        public Student() { }
        public Student(string firstName, string lastName, string address, int year, double fee, string program):base(firstName,lastName, address)
        {
            Year = year;
            Fee = fee;
            Program = program;
        }
        #endregion
        #region Methods
        public static void ToList(List<Student> list)
        {
            Student temp = MakeStudent();
            list.Add(temp);
        }
        public static Student MakeStudent()
        {
            Console.Write("What is the student's first name: ");
            string firstname = Validator.ValidateString();
            Console.Write("What is the person's last name: ");
            string lastname = Validator.ValidateString();
            Console.Write("What is the person's address: ");
            var address = Console.ReadLine();
            Console.Write("What is the persons year: (number) ");
            int year = Validator.ValidateInt();
            Console.Write("What is the Fee for this student?");
            double fee = Validator.ValidateDouble(); 
            Console.Write("What is the program this student is in: ");
            string program  = Validator.ValidateProgram();


            Student temp = new Student(firstname,lastname,address,year,fee,program );
            return temp;
        }
        public int year
        {
            get
            {
                return Year;
            }
            set
            {
                Year = value;
            }
        }
        public double fee
        {
            get
            {
                return Fee;
            }
            set
            {
                Fee = value;
            }
        }
        public string program
        {
            get
            {
                return Program;
            }
            set
            {
                Program = value;
            }
        }

        public virtual int CompareTo(Student temp)
        {
            if (this.lastName == temp.lastName)
            {
                return this.firstName.CompareTo(temp.firstName);
            }
            return this.lastName.CompareTo(temp.lastName);
        }

        public override string ToString()
        {
            return $"Student: {lastName}, {firstName}. Their address is {address} program: {program} Year: {year} Fee: {fee}";
        }
        #endregion
    }
}
