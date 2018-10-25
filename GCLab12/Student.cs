using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLab12
{
    class Student:Person,People
    {
        #region Data
        private int Year;
        private double Fee;
        private string Program;
        #endregion
        #region Constructor
        public Student(string name, string address, int year, double fee, string program):base(name, address)
        {
            Year = year;
            Fee = fee;
            Program = program;
        }
        #endregion
        #region Methods
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
        public override string ToString()
        {
            return $"Student[Person[{name}, {address}], {program}, {year}, {fee}]";
        }
        #endregion
    }
}
