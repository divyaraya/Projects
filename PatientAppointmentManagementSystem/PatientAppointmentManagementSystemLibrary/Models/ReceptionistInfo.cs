

namespace PatientAppointmentManagementSystemLibrary.Models
{
    public class ReceptionistInfo
    {
        private string _firstName;
        private string _lastName;
        private string _address;
        private string _phoneNo;
        private Shift _workingShift;

        public ReceptionistInfo(string firstName, string lastName, string address, string phoneNo, Shift workingShift)
        {
            this._firstName = firstName;
            this._lastName = lastName;
            this._address = address;
            this._phoneNo = phoneNo;
            this._workingShift = workingShift;

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

        public Shift WorkingShift
        {
            get { return _workingShift; }
            set { _workingShift = value; }
        }
    }
}
