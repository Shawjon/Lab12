using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLab12
{
    public class ArchivedStudent : Student, IComparable<ArchivedStudent>
    {
        private int FinalScore;
        public int finalScore
        {
            get
            {
                return FinalScore;
            }
            set
            {
                FinalScore = value;
            }
        }

        public ArchivedStudent()
        {
        }

        public ArchivedStudent(string firstName,string lastName, string address, int year, double fee, string program, int finalScore) : base(firstName, lastName, address, year, fee, program)
        {
            FinalScore = finalScore;
        }



      
        public static ArchivedStudent MakeArchivedStudent()
        {
            Console.Write("What is the student's first name: ");
            string firstname = Validator.ValidateString();
            Console.Write("What is the person's last name: ");
            string lastname = Validator.ValidateString();
            Console.Write("What is the person's address: ");
            var address = Console.ReadLine();
            Console.Write("What was the person's year: (number) ");
            int year = Validator.ValidateInt();
            Console.Write("What was the Fee for this student: ");
            double fee = Validator.ValidateDouble();
            Console.Write("What is the program this student was in: ");
            string program = Validator.ValidateProgram();
            Console.Write("What is the Final score for this student: ");
            int finalscore = Validator.ValidateScore();


            ArchivedStudent temp = new ArchivedStudent(firstname, lastname, address, year, fee, program,finalscore);
            return temp;
        }
        public  int CompareTo(ArchivedStudent temp)
        {

            if (this.FinalScore == temp.FinalScore)
            {
                return this.lastName.CompareTo(temp.lastName);
            }
            return temp.FinalScore.CompareTo(this.FinalScore);
        }
        public override string ToString()
        {
            //return base.ToString() + $"Final score {finalScore}";
            return $"Student: {lastName}, {firstName}. Their address is {address} program: {program} Year: {year} Fee: {fee} Final Score {finalScore}";
        }
    }
}
