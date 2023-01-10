// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.IO;
using HospitalApp;
//b) initialise rooms and doctors
void InitData(List<Room> roomList, List<Doctor> doctorList)
{
    //Location & Ward class added into room list
    Room r1 = new Room("#01-01", "C");
    Room r2 = new Room("#02-02", "B");
    Room r3 = new Room("#03-03", "A");
    Room r4 = new Room("#04-04", "A");

    //NRIC, name and department added into doctor list 
    Doctor d1 = new Doctor("S1234567A", "Tom", "Pediatrics");
    Doctor d2 = new Doctor("S2345678A", "Champ", "Oncology");
    Doctor d3 = new Doctor("S3456789B", "Terry", "Cardiology");

    roomList.Add(r1);
    roomList.Add(r2);
    roomList.Add(r3);
    roomList.Add(r4);

    doctorList.Add(d1);
    doctorList.Add(d2);
    doctorList.Add(d3);
    //add data into csv file
    /*    using (StreamWriter sq = new StreamWriter("Patients.csv", true))
        {
            string data1 = Convert.ToString(r1.ToString());
            string data2 = Convert.ToString(r2.ToString());
            string data3 = Convert.ToString(r3.ToString());
            string data4 = Convert.ToString(r4.ToString());
        }*/
}
List<Room> roomList = new();
List<Doctor> doctorList = new();
//call InitData function
InitData(roomList, doctorList);

//ii) display content
/*foreach(var r in roomList)
{
    Console.WriteLine("{0} {1}", r.Location, r.WardClass);
}
foreach(var d in doctorList)
{
    Console.WriteLine("{0} {1} {2}", d.NRIC, d.Name, d.Department);
}*/

//c) create patients records from text files
void CreatePatients(List<Patient> patientList, List<Room> roomList)
{
    string[] csvLines = File.ReadAllLines("Patients.csv");
    for (int i = 1; i < csvLines.Length; i++)
    {
        string[] eachpatient = csvLines[i].Split(',');
        //Console.WriteLine("{0,10} {1,18} {2,15}", eachpatient[0], eachpatient[1], eachpatient[2]);
        var r = roomList.Find(x => eachpatient[2].Equals(x.Location));
        /* foreach(var room in roomList)
        {
            if (eachpatient[2].Equals(room.Location))
            {
                Console.WriteLine(room.WardClass);
                break;
            }
        } */
        Patient p = new Patient(eachpatient[0], eachpatient[1], r);
        patientList.Add(p);
    }
}

List<Patient> patientList = new();
CreatePatients(patientList, roomList);
foreach(var p in patientList)
{
    Console.WriteLine("{0} {1} {2}",p.NRIC, p.Name, p.WardedAt.Location);
}

