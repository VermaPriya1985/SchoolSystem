using System;
namespace SchoolSystem
{
    public class Student
    {

        public Student(long studentid, string studentname, int age, 
        string gender, long admissionno, string mothername, string fathername,
        string address, long mobileno, string dateofbirth) 
        {
            StudentId = studentid;
            StudentName= studentname;
            // LastName = lastname;
            Age=age;
            Gender=gender;
            AdmissionNo=admissionno;
            MotherName=mothername;
            FatherName=fathername;
            Address=address;
            MobileNo=mobileno;
            DateOfBirth=dateofbirth;
        }


        // Data Members
        public long StudentId { get; }
        public string StudentName { get; private set; }
        // public string LastName { get; private set; }
        public int Age { get; private set; }
        public string Gender { get; private set; }
        public long AdmissionNo { get; private set; }
        public string MotherName { get; private set; }
        public string FatherName { get; private set; }
        public string Address { get; private set; }
        public long MobileNo { get; private set; }
        public string DateOfBirth { get; private set; }

    }
}