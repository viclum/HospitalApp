using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalApp
{
    class Room
    {
        public string Location { get; set; }
        public string WardClass { get; set; }
        public Room(string l, string w)
        {
            Location = l;
            WardClass = w;
        }
        public override string ToString()
        {
            return "Location:" + Location + "\tWardClass:" + WardClass;
        }
    }
}
