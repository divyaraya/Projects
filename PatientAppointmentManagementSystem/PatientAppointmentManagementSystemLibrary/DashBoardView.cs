using PatientAppointmentManagementSystemLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PatientAppointmentManagementSystemLibrary
{
    public class DashBoardView
    {
        public void DashboardView(List<PatientInfo> registeredPatients)
        {
            Console.WriteLine("\n");
            Console.WriteLine("------------------------");
            Console.WriteLine("------------------------");
            Console.WriteLine("\n");
            Console.WriteLine("Welcome To DashBoard \n");

            try
            {
                var flag = true;
                while (flag)
                {
                    Console.WriteLine("Enter date in yyyy, mm, dd format to look for Datewise appointment list \n");
                    DateTime date = Convert.ToDateTime(Console.ReadLine());

                    List<PatientInfo> appointmentList = registeredPatients.Where(item => (item.ExpectedAppointment == date)).ToList();

                    foreach (var item in appointmentList)
                    {
                        Console.WriteLine("Doctor: {0} -- Department: {1} -- Patient: {2}", item.DoctorAppointed, item.Department, item.FirstName);
                    }

                    if (appointmentList.Count <= 0)
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("No appointments for the date: {0}", date.ToString("d"));
                    }

                    Console.WriteLine("\n");
                    Console.WriteLine("Do you want to continue? (y/n)");
                    var result = Console.ReadLine();

                    if (result == "n")
                    {
                        flag = false;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception {0} has occured", e.Message);
            }
        }
    }
}
