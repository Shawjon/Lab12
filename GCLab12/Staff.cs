﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLab12
{
    public class Staff:Person,People
    {
        #region Data
        private string School;
        private double Pay;
        #endregion
        #region Constructor
        public Staff (string firstName, string lastName, string address, string school, double pay):base (firstName,lastName, address)
        {
            Pay = pay;
            School = school;
        }
        #endregion
        #region Methods
        public string school
        {
            get
            {
                return School;
            }
            set
            {
                School = value;
            }
        }
        public double pay
        {
            get
            {
                return Pay;
            }
            set
            {
                Pay = value;
            }
        }
        public override string ToString()
        {
            return $"Staff[Person[{firstName} {lastName}, {address}], {school}, {pay}]";
        }
        #endregion
    }
}
