using System;
namespace SchoolSystem
{
    public class Subject
    {
        
         // Constructor
        public Subject(long subjectid, string subjectname)
        {
            SubjectId = subjectid;
            SubjectName= subjectname;
       
        }


        // Data Members
        public long SubjectId { get; }
        public string SubjectName { get; private set; }
       
       
    }
}