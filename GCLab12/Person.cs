using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLab12
{
    public class Person:People
    {
        #region Data
        private string FirstName;
        private string Address;
        private string LastName;
        #endregion
        #region Constructor
        public Person()
        {
        }

        public Person (string firstName,string lastName, string address)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
        }


        #endregion
        #region Methods
        public string firstName
        {
            set
            {
                FirstName = value;
            }
            get
            {
                return FirstName;
            }
        }
        public string lastName
        {
            set
            {
                LastName = value;
            }
            get
            {
                return LastName;
            }
        }
        public string address
        {
            set
            {
                Address = value;
            }
            get
            {
                return Address;
            }
        }
        public override string ToString()
        {
            
            return $"Person[{firstName} {lastName}, {address}]";
        }
        #endregion

    }



}
