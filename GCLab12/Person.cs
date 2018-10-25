using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLab12
{
    class Person:People
    {
        #region Data
        private string Name;
        private string Address;
        #endregion
        #region Constructor
        public Person (string name, string address)
        {
            Name = name;
            Address = address;
        }
        #endregion
        #region Methods
        public string name
        {
            set
            {
                Name = value;
            }
            get
            {
                return Name;
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
            
            return $"Person[{name}, {address}]";
        }
        #endregion

    }



}
