using System;
using System.Collections.Generic;
using PatientAppointmentManagementSystemLibrary.HelperClass;
using PatientAppointmentManagementSystemLibrary.Models;


namespace PatientAppointmentManagementSystemLibrary
{
    public class PatientAppointment
    {
        public event EventHandler<DoctorInfo> AppointmentNotification;

        public void RegistrationDesk()
        {
            PatientAppointmentHelperClass patientAppointmentHelper = new PatientAppointmentHelperClass();

            var doctorList = patientAppointmentHelper.AddDoctor();
            patientAppointmentHelper.AddReceptionist();
            var patinetInfoList = patientAppointmentHelper.AddPatient();


            AppointmentNotification += SendSMSNotification;
            AppointmentNotification += SendMailNotification;

            var flag = true;
            while (flag)
            {
                Console.WriteLine("WELCOME TO REGISTRATION DESK \n");

                Console.WriteLine("Add the patient details here");
                Console.WriteLine("PatientID");
                string patientID = Console.ReadLine();
                Console.WriteLine("First Name");
                string firstName = Console.ReadLine();
                Console.WriteLine("Last Name");
                string lastName = Console.ReadLine();
                Console.WriteLine("Age");
                int age = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Gender");
                string gender = Console.ReadLine();
                Console.WriteLine("Phone Number");
                string phoneNo = Console.ReadLine();
                Console.WriteLine("Address");
                string address = Console.ReadLine();
                Console.WriteLine("Health Problem (Ex: Fever, ENT, Cold, heart desease, Dental, Accident, Skin care, Cancer, Hair Loss");
                string healthIssue = Console.ReadLine();
                Console.WriteLine("Appointments will be given only for current month");
                Console.WriteLine("Enter appointment date in yyyy, mm, dd format(In case of Emmergency enter today's date)");
                DateTime expectedAppointmentDate = Convert.ToDateTime(Console.ReadLine());

                var department = SelectDepartment(healthIssue, age);
                var appointedDoctor = SelectDoctor(department, doctorList, expectedAppointmentDate);

                patinetInfoList.Add(new PatientInfo(firstName, lastName, patientID, age, gender, address, phoneNo, healthIssue, expectedAppointmentDate, appointedDoctor.FirstName, department));

                Console.WriteLine("\n");
                Console.WriteLine("Do you want to continue adding patients? (y/n)");
                var result = Console.ReadLine();

                if (result == "n")
                {
                    flag = false;
                }
            }
            DashBoardView dashBoardView = new DashBoardView();
            dashBoardView.DashboardView(patinetInfoList);
        }

        public DepartmentInfo SelectDepartment(string healthIssue, int age)
        {
            DepartmentClassHelper assignDepartment = new DepartmentClassHelper();
            DepartmentInfo departmentSelected = assignDepartment.AssignToDepartment(healthIssue, age);
            return departmentSelected;
        }

        public DoctorInfo SelectDoctor(DepartmentInfo department, List<DoctorInfo> doctorList, DateTime appointmentDate)
        {
            DoctorClassHelper doctorClassHelper = new DoctorClassHelper();
            DoctorInfo doctorSelected = doctorClassHelper.AssignDoctor(department, doctorList, appointmentDate);
            Console.WriteLine("\n");
            Console.WriteLine("The Patient has been given Appointment with the Dr." + doctorSelected.FirstName + " of the " + department + " Department"+ " on "+ appointmentDate.ToString("d")+" "+ doctorSelected.WorkingShift);
            AppointmentNotification?.Invoke(this, doctorSelected);

            return doctorSelected;
        }

        public void SendSMSNotification(object sender, DoctorInfo doctor)
        {
            Console.WriteLine("\n");
            Console.WriteLine("Appointment has been made with Dr.{0}, SMS Notification send to doctor and patient", doctor.FirstName);
        }

        public void SendMailNotification(object sender, DoctorInfo doctor)
        {
            Console.WriteLine("\n");
            Console.WriteLine("Appointment has been made with Dr.{0}, Mail Notification send to doctor and patient", doctor.FirstName);
        }
    }
}

