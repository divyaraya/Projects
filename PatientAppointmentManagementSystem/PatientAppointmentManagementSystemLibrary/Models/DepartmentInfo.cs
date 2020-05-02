using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointmentManagementSystemLibrary.Models
{ 
    public enum DepartmentInfo
    {
        General_Physician,       
        Emergency,
        ENT,
        Dentist,
        Pediatrician,
        Dermatologist,
        Oncology,
        Cardiology,
    }

    public enum Shift
    {
        Morning,
        Evening,
        Night
    }
}
