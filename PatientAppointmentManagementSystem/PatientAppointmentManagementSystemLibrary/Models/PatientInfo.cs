
using System;

namespace PatientAppointmentManagementSystemLibrary.Models
{
    public class PatientInfo
    {
        private string _firstName;
        private string _lastName;
        private string _patientID;
        private int _age;
        private string _gender;
        private string _address;
        private string _phoneNo;
        private string _healthIssue;
        private DateTime _expectedAppointment;
        private string _doctorAppointed;
        private DepartmentInfo _department;

        public PatientInfo(string firstName, string lastName, string patientID, int age, string gender, string address, string phoneNo, string healthIssue, DateTime expectedAppointment, string doctorAppointed, DepartmentInfo department)
        {
            this._firstName = firstName;
            this._lastName = lastName;
            this._patientID = patientID;
            this._age = age;
            this._gender = gender;
            this._address = address;
            this._phoneNo = phoneNo;
            this._healthIssue = healthIssue;
            this._expectedAppointment = expectedAppointment;
            this._doctorAppointed = doctorAppointed;
            this._department = department;
        }

        public string FirstName
        {
            get {return _firstName;}
            set { _firstName = value;}
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public string PatientID
        {
            get { return _patientID; }
            set { _patientID = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public string PhoneNo
        {
            get { return _phoneNo; }
            set { _phoneNo = value; }
        }

        public string HealthIssue
        {
            get { return _healthIssue; }
            set { _healthIssue = value; }
        }

        public DateTime ExpectedAppointment
        {
            get { return _expectedAppointment; }
            set { _expectedAppointment = value; }
        }

        public string DoctorAppointed
        {
            get { return _doctorAppointed; }
            set { _doctorAppointed = value; }
        }

        public DepartmentInfo Department
        {
            get { return _department; }
            set { _department = value; }
        }
    }
}
