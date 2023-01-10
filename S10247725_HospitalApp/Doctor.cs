using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalApp
{
    class Doctor : Person
    {
        public string Department { get; set; }
        public List<Patient> patientList { get; set; }
                         = new List<Patient>();

        public Doctor(string d, string nr, string na)
        {
            Department = d;
            NRIC = nr;
            Name = na;
        }
        public void AddPatient(Patient p)
        {
            patientList.Add(p);
        }
        public void RemovePatient(Patient p)
        {
            patientList.Remove(p);
        }
        public override string ToString()
        {
            return base.ToString() + "\tDepartment: " + Department;
        }

    }
}
