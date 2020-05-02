using PatientAppointmentManagementSystemLibrary.Models;
using System;

namespace PatientAppointmentManagementSystemLibrary.HelperClass
{
    public class DepartmentClassHelper
    {
        public DepartmentInfo AssignToDepartment(string sickness, int age)
        {          
            if (age <= 14)
            {
                return DepartmentInfo.Pediatrician;
            }
            else
            {
                if (sickness.Equals("Fever") || sickness.Equals("Cold"))
                {
                    return DepartmentInfo.General_Physician;
                }
                else if (sickness.Equals("Cancer"))
                {
                    return DepartmentInfo.Oncology;
                }
                else if (sickness.Equals("Skin care") || sickness.Equals("Hair Loss"))
                {
                    return DepartmentInfo.Dermatologist;
                }
                else if (sickness.Equals("heart desease"))
                {
                    return DepartmentInfo.Cardiology;
                }
                else if (sickness.Equals("Dental"))
                {
                    return DepartmentInfo.Dentist;
                }
                else if (sickness.Equals("ENT"))
                {
                    return DepartmentInfo.ENT;
                }
                else if (sickness.Equals("Accident") || sickness.Equals("Unconscious"))
                {
                    return DepartmentInfo.Emergency;
                }
                else
                {
                    return DepartmentInfo.General_Physician;
                }               
            }
        }
    }
}
