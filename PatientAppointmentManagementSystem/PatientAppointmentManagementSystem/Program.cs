using System;
using PatientAppointmentManagementSystemLibrary;

namespace PatientAppointmentManagementSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO ABC HOSPITAL \n");
            Console.WriteLine("Visit Registration Desk to Take Appionment \n");
            PatientAppointment patientAppioment = new PatientAppointment();
            patientAppioment.RegistrationDesk();
            Console.ReadLine();

        }
    }
}
