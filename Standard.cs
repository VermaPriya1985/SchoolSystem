using System;
namespace SchoolSystem
{
    public class Standard
    {
        
         // Constructor
        public Standard(long standardid, string standardname)
        {
            StandardId = standardid;
            StandardName= standardname;
       
        }


        // Data Members
        public long StandardId { get; }
        public string StandardName { get; private set; }
       
       
    }
}