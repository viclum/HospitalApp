using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalApp
{
    class Person
    {
        public string NRIC { get; set; }
        public string Name { get; set; }
        //public Person() { }
        public Person(string nr, string na)
        {
            NRIC = nr;
            Name = na;
        }
        public override string ToString()
        {
            return "NRIC:" + NRIC + "Name:" + Name;
        }
    }
}
