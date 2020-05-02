using System;
using System.Collections.Generic;
using PatientAppointmentManagementSystemLibrary.Models;

namespace PatientAppointmentManagementSystemLibrary.HelperClass
{
    public class PatientAppointmentHelperClass
    {
        public List<DoctorInfo> AddDoctor()
        {
            List<DoctorInfo> doctorInfoList = new List<DoctorInfo>();
            doctorInfoList.Add(new DoctorInfo("Asha", "Rani", "Bangalore", "1234", DepartmentInfo.Dentist, Shift.Morning, new DateTime(2020, 4, 30), new DateTime(2020, 5, 15)));
            doctorInfoList.Add(new DoctorInfo("Usha", "P", "Mangalore", "984567", DepartmentInfo.Dentist, Shift.Evening, new DateTime(2020, 5, 14), new DateTime(2020, 5, 31)));
            doctorInfoList.Add(new DoctorInfo("Ajay", "Patel", "Tumkur", "848900", DepartmentInfo.Dermatologist, Shift.Morning, new DateTime(2020, 4, 30), new DateTime(2020, 5, 31)));
            doctorInfoList.Add(new DoctorInfo("Bindu", "Shree", "Bagalkote", "688903", DepartmentInfo.Emergency, Shift.Morning, new DateTime(2020, 4, 30), new DateTime(2020, 5, 15)));
            doctorInfoList.Add(new DoctorInfo("Hima", "V", "Tumkur", "845880", DepartmentInfo.General_Physician, Shift.Morning, new DateTime(2020, 4, 30), new DateTime(2020, 5, 15)));
            doctorInfoList.Add(new DoctorInfo("Hema", "S", "Bellary", "249i0", DepartmentInfo.Oncology, Shift.Evening, new DateTime(2020, 4, 30), new DateTime(2020, 5, 31)));
            doctorInfoList.Add(new DoctorInfo("Ashok", "Patil", "Bangalore", "76999000", DepartmentInfo.Cardiology, Shift.Morning, new DateTime(2020, 4, 30), new DateTime(2020, 5, 31)));
            doctorInfoList.Add(new DoctorInfo("Ramya", "R", "Kolar", "346565", DepartmentInfo.Pediatrician, Shift.Morning, new DateTime(2020, 4, 30), new DateTime(2020, 5, 31)));
            doctorInfoList.Add(new DoctorInfo("Yogendra", "K", "Davanagere", "4565777", DepartmentInfo.General_Physician, Shift.Evening, new DateTime(2020, 5, 14), new DateTime(2020, 5, 31)));
            doctorInfoList.Add(new DoctorInfo("Rakesh", "A", "Kolar", "4753226", DepartmentInfo.Emergency, Shift.Night, new DateTime(2020, 5, 14), new DateTime(2020, 5, 31)));
            doctorInfoList.Add(new DoctorInfo("Deepak", "Naidu", "Bangalore", "5677888226", DepartmentInfo.ENT, Shift.Morning, new DateTime(2020, 4, 30), new DateTime(2020, 5, 31)));

            return doctorInfoList;

        }

        public List<ReceptionistInfo> AddReceptionist()
        {
            List<ReceptionistInfo> receptionistInfoList = new List<ReceptionistInfo>();
            receptionistInfoList.Add(new ReceptionistInfo("Meena", "Malivor", "Bangalore", "1268834", Shift.Morning));
            receptionistInfoList.Add(new ReceptionistInfo("Sharon", "Paul", "Tumkur", "84846900", Shift.Evening));
            receptionistInfoList.Add(new ReceptionistInfo("Jessica", "Potter", "Kolar", "476689536", Shift.Night));
            return receptionistInfoList;
        }

        public List<PatientInfo> AddPatient()
        {
            List<PatientInfo> PatientInfoList = new List<PatientInfo>();
            PatientInfoList.Add(new PatientInfo("Jhone", "Doe","156", 36, "M", "Bangalore", "6587990", "Skin Care", new DateTime(2020, 5, 3), "Ajay", DepartmentInfo.Dermatologist));
            PatientInfoList.Add(new PatientInfo("Rama", "Nayak", "112", 56, "M", "Kolar", "6589670", "heart desease", new DateTime(2020, 5, 4), "Ashok", DepartmentInfo.Cardiology));
            PatientInfoList.Add(new PatientInfo("Thilak", "M", "13", 28, "M", "Tumkur", "9463590", "Dental", new DateTime(2020, 5, 22), "Usha", DepartmentInfo.Dentist));
            PatientInfoList.Add(new PatientInfo("Prakash", "P", "543", 45, "M", "Nelamangala", "745263590", "Accident", DateTime.Now, "Bindu", DepartmentInfo.Emergency));
            PatientInfoList.Add(new PatientInfo("Rajat", "Rokade", "234", 20, "M", "Tumkur", "9668999", "ENT", new DateTime(2020, 5, 9), "Deepak", DepartmentInfo.ENT));
            PatientInfoList.Add(new PatientInfo("Ramappa", "B R", "56", 65, "M", "Bagalkote", "3456590", "Cancer", new DateTime(2020, 5, 13), "Hema", DepartmentInfo.Oncology));
            PatientInfoList.Add(new PatientInfo("Bindu", "Shree", "17", 10, "F", "Mysore", "785635", "Fever", new DateTime(2020, 5, 19), "Ramya", DepartmentInfo.Pediatrician));
            PatientInfoList.Add(new PatientInfo("Veena", "Patil", "90", 32, "F", "Davanagere", "7996398", "Cold", new DateTime(2020, 5, 25), "Yogendra", DepartmentInfo.General_Physician));
            PatientInfoList.Add(new PatientInfo("Ayush", "Kumari", "45", 49, "F", "Kolar", "454630", "Dental", new DateTime(2020, 5, 5), "Asha", DepartmentInfo.Dentist));
            PatientInfoList.Add(new PatientInfo("Raja", "Rathod", "675", 58, "M", "Kolar", "786347667", "Fever", new DateTime(2020, 5, 5), "Hima", DepartmentInfo.General_Physician));
            return PatientInfoList;
        }
    }
}
