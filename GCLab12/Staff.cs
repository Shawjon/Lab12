using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLab12
{
    class Staff:Person,People
    {
        #region Data
        private string School;
        private double Pay;
        #endregion
        #region Constructor
        public Staff (string name, string address, string school, double pay):base (name, address)
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
            return $"Staff[Person[{name}, {address}], {school}, {pay}]";
        }
        #endregion
    }
}
