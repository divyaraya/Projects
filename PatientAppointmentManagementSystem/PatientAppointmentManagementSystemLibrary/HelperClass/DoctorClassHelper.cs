using PatientAppointmentManagementSystemLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PatientAppointmentManagementSystemLibrary.HelperClass
{
    public class DoctorClassHelper
    {
        public DoctorInfo AssignDoctor(DepartmentInfo department, List<DoctorInfo> doctorList, DateTime appointmentDate)
        {
            if(department == DepartmentInfo.Cardiology)
            {
                var availableDoctor = doctorList.Where(item => (item.Specialization == DepartmentInfo.Cardiology) 
                                      && ((appointmentDate > item.AvailableDateFrom)
                                      && (appointmentDate < item.AvailableDateTo)))
                                      .FirstOrDefault();
                return availableDoctor;
            }

            if (department == DepartmentInfo.Dentist)
            {
                var availableDoctor = doctorList.Where(item => (item.Specialization == DepartmentInfo.Dentist)
                                      && ((appointmentDate > item.AvailableDateFrom)
                                      && (appointmentDate < item.AvailableDateTo)))
                                      .FirstOrDefault();
                return availableDoctor;
            }

            if (department == DepartmentInfo.Dermatologist)
            {
                var availableDoctor = doctorList.Where(item => (item.Specialization == DepartmentInfo.Dermatologist)
                                      && ((appointmentDate > item.AvailableDateFrom)
                                      && (appointmentDate < item.AvailableDateTo)))
                                      .FirstOrDefault();
                return availableDoctor;
            }

            if (department == DepartmentInfo.Emergency)
            {
                var availableDoctor = doctorList.Where(item => (item.Specialization == DepartmentInfo.Emergency)
                                      && ((DateTime.Now > item.AvailableDateFrom)
                                      && (DateTime.Now < item.AvailableDateTo)))
                                      .FirstOrDefault();
                return availableDoctor;
            }

            if (department == DepartmentInfo.Oncology)
            {
                var availableDoctor = doctorList.Where(item => (item.Specialization == DepartmentInfo.Oncology)
                                      && ((appointmentDate > item.AvailableDateFrom)
                                      && (appointmentDate < item.AvailableDateTo)))
                                      .FirstOrDefault();
                return availableDoctor;
            }

            if (department == DepartmentInfo.ENT)
            {
                var availableDoctor = doctorList.Where(item => (item.Specialization == DepartmentInfo.ENT)
                                      && ((appointmentDate > item.AvailableDateFrom)
                                      && (appointmentDate < item.AvailableDateTo)))
                                      .FirstOrDefault();
                return availableDoctor;
            }

            if (department == DepartmentInfo.Pediatrician)
            {
                var availableDoctor = doctorList.Where(item => (item.Specialization == DepartmentInfo.Pediatrician)
                                      && ((appointmentDate > item.AvailableDateFrom)
                                      && (appointmentDate < item.AvailableDateTo)))
                                      .FirstOrDefault();
                return availableDoctor;
            }

            if (department == DepartmentInfo.General_Physician)
            {
                var availableDoctor = doctorList.Where(item => (item.Specialization == DepartmentInfo.General_Physician)
                                      && ((appointmentDate > item.AvailableDateFrom)
                                      && (appointmentDate < item.AvailableDateTo)))
                                      .FirstOrDefault();
                return availableDoctor;
            }

            else
            {
                var availableDoctor = doctorList.Where(item => (item.Specialization == DepartmentInfo.General_Physician)
                      && ((appointmentDate > item.AvailableDateFrom)
                      && (appointmentDate < item.AvailableDateTo)))
                      .FirstOrDefault();
                return availableDoctor;
            }

        }
    }
}
