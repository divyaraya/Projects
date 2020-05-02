
using System;

namespace PatientAppointmentManagementSystemLibrary.Models
{
    public class DoctorInfo
    {
        private string _firstName;
        private string _lastName;
        private string _address;
        private string _phoneNo;
        private DepartmentInfo _specialization;
        private Shift _workingShift;
        private DateTime _availableDateFrom;
        private DateTime _availableDateTo;

        public DoctorInfo(string firstName, string lastName, string address, string phoneNo, DepartmentInfo specialization, Shift workingShift, DateTime availableDateFrom, DateTime availableDateTo)
        {
            this._firstName = firstName;
            this._lastName = lastName;
            this._address = address;
            this._phoneNo = phoneNo;
            this._specialization = specialization;
            this._workingShift = workingShift;
            this._availableDateFrom = availableDateFrom;
            this._availableDateTo = availableDateTo;

        }
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
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

        public DepartmentInfo Specialization
        {
            get { return _specialization; }
            set { _specialization = value; }
        }

        public Shift WorkingShift
        {
            get { return _workingShift; }
            set { _workingShift = value; }
        }

        public DateTime AvailableDateFrom
        {
            get { return _availableDateFrom; }
            set { _availableDateFrom = value; }
        }
        public DateTime AvailableDateTo
        {
            get { return _availableDateTo; }
            set { _availableDateTo = value; }
        }
    }
}
