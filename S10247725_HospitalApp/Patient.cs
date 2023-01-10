using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalApp
{
    class Patient : Person
    {
        public Room WardedAt { get; set; }
        public Patient(string nr, string na, Room w)
        {
            NRIC = nr;
            Name = na;
            WardedAt = w;
        }
        public override string ToString()
        {
            return base.ToString() + "\tPatient's room:" + WardedAt;
        }
    }
}
