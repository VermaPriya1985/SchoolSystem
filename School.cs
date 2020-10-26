using System;
using System.Collections.Generic;
namespace SchoolSystem
{
    public class School
    {
        
       public School()
        {

        _student = new List<Student>();        
        _standard = new List<Standard>();
        _subject = new List<Subject>();

        // Hardcode Student
        var  student1 = new Student(12345,"Priya Verma",5,"Female",
        12345,"Veena Rani","Ashwani Kumar","Retallack Street",6399999297,"1985-11-21");
        
        var  student2 = new Student(12346,"Atul Verma",5,"Female",12346,"Veena Rani",
        "Ashwani Kumar","Retallack Street",6399999297,"21-11-1985");
        
        var  student3 = new Student(12347,"Gavin Verma",5,"Female",12347,"Veena Rani",
        "Ashwani Kumar","Retallack Street",6399999297,"21-11-1985");
        
        var  student4 = new Student(12348,"Jiya Verma",5,"Female",12348,"Veena Rani",
        "Ashwani Kumar","Retallack Street",6399999297,"21-11-1985");
         
        _student.Add(student1);
        _student.Add(student2);
        _student.Add(student3);
        _student.Add(student4);
        
        // HardCode Standard
        var  standard1 = new Standard(1,"Grade Ist");
        var  standard2 = new Standard(2,"Grade 2nd");
        var  standard3 = new Standard(3,"Grade 3rd");
        
        _standard.Add(standard1);
        _standard.Add(standard2);
        _standard.Add(standard3);
        
        // Hardcode Section
        var subject1 = new Subject(1,"English");
        var subject2 = new Subject(2,"Math");
        var subject3 = new Subject(3,"Science");
        
        _subject.Add(subject1);
        _subject.Add(subject2);
        _subject.Add(subject3);
    

        }

        
        // Data Member to represent Student, Standard, Subject
        private List<Student> _student;
        
        private List<Standard> _standard;
        
        private List<Subject> _subject;


        // Search Student 
        public Student SearchForStudent(string studentname)
        {
        Console.WriteLine($"Searching for Student: {studentname}");
        for(int i=0;i<_student.Count;i++)
        {

            Student nextstudent = _student[i];
            if (nextstudent.StudentName.ToLower() == studentname.ToLower()) 
            {
                    return nextstudent;
            }
        }
        return null; 

        } 
   

        // Search Standard 
        public Standard SearchForStandard(string standardname)
        {
        Console.WriteLine($"Searching for Standard: {standardname}");
        for(int i=0;i<_standard.Count;i++)
        {

            Standard nextstandard = _standard[i];
            if (nextstandard.StandardName.ToLower() == standardname.ToLower()) 
            {
                    return nextstandard;
            }
        }
        return null; // NULL is absence of standard
        } 

        // Allocate Standard to Student
        public bool AllocateStandardToStudent(long studentid, long standardid)
        {

        bool studentExist = false;
        bool standardExist = false;
        bool result = false;

        // Validate studentid
        for(int i=0;i<_student.Count;i++)
        {
            var nextstudent = _student[i];
            if(nextstudent.StudentId==studentid)
            {
                studentExist = true; 
                result = true;
            }
        }

        // handle if studentid does not exists
        if(!studentExist)
        {
            throw new Exception($"studentid does not exists {studentid}");
        }

        // validate standardid
        for(int i=0;i<_standard.Count;i++)
        {
            var nextstandard = _standard[i];
            if(nextstandard.StandardId == standardid)
            {
                standardExist = true; 
                result = true;
            }
        } 

        if (!standardExist) 
        {
                throw new Exception($"Standard {standardid} does not exist!!");
        }
        return result;
    }
    
        // Allocate Subject to Standard
        public bool AllocateSubjectToStandard(long subjectid, long standardid)
        {

        bool subjectExist = false;
        bool standardExist = false;
        bool result = false;

        // Validate subjectid
        for(int i=0;i<_subject.Count;i++)
        {
            var nextsubject = _subject[i];
            if(nextsubject.SubjectId==subjectid)
            {
                subjectExist = true; 
                result = true;
            }
        }

        // handle if subjectid does not exists
        if(!subjectExist)
        {
            throw new Exception($"subjectid does not exists {subjectid}");
        }

        // validate standardid
        for(int i=0;i<_standard.Count;i++)
        {
            var nextstandard = _standard[i];
            if(nextstandard.StandardId == standardid)
            {
                standardExist = true; 
                result = true;
            }
        } 

        if (!standardExist) 
        {
                throw new Exception($"Standard {standardid} does not exist!!");
        }
        return result;
    }
    
        // Search Subject
        public Subject SearchForSubject(string subjectname)
        {
        Console.WriteLine($"Searching for Subject: {subjectname}");
        for(int i=0;i<_subject.Count;i++)
        {

            Subject nextsubject = _subject[i];
            if (nextsubject.SubjectName.ToLower() == subjectname.ToLower()) 
            {
                    return nextsubject;
            }
        }
        return null; // NULL is absence of book
        } 
 
    }
}