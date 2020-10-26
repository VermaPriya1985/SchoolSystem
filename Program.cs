using System;

namespace SchoolSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            // start
            School theSchool = new School();
            Console.WriteLine("Welcome to the School!");
            while(true)
            {
                Console.WriteLine("Enter s- to search for student, st- to search for standard, a-- to allocate standard to student, ss-- to allocate subject to standard, su-- to search for subject, q-quit");
                string userInput = Console.ReadLine();
                // Search Student
                if(userInput=="s")
                {
                    Console.WriteLine("Enter Student Name to search for?");
                    string name = Console.ReadLine();
                    Student result = theSchool.SearchForStudent(name);
                    if (result == null) 
                    {
                        Console.WriteLine("Student was not found");
                    } 
                    else 
                    {
                        Console.WriteLine($"Found a student with Id: {result.StudentId} ");
                    }

                }
                // Search Standard
                if(userInput=="st")
                {
                    Console.WriteLine("Enter Standard Name to search for?");
                    string name = Console.ReadLine();
                    Standard result = theSchool.SearchForStandard(name);
                    if (result == null) 
                    {
                        Console.WriteLine("Standard was not found");
                    } 
                    else 
                    {
                        Console.WriteLine($"Found a standard with Id: {result.StandardId} ");
                    }

                }
                // Search for Subject
                if(userInput=="su")
                {
                    Console.WriteLine("Enter Subject Name to search for?");
                    string name = Console.ReadLine();
                    Subject result = theSchool.SearchForSubject(name);
                    if (result == null) 
                    {
                        Console.WriteLine("Subject was not found");
                    } 
                    else 
                    {
                        Console.WriteLine($"Found a subject with Id: {result.SubjectId} ");
                    }

                }
                // Allocate Standard to Student
                if(userInput=="a")
                {
                    Console.WriteLine("Enter StudentID");
                    string studentidinput = Console.ReadLine();
                    long studentId = Convert.ToInt64(studentidinput);

                    Console.WriteLine("Enter StandardID");
                    string standardidinput = Console.ReadLine();
                    long standardId = Convert.ToInt64(standardidinput);
                    
                    bool success = theSchool.AllocateStandardToStudent(studentId,standardId);
                    if(success) 
                    {
                        Console.WriteLine("Standard has been allocated to Student");
                    } 
                    else 
                    {
                        Console.WriteLine("Please enter correct value");
                    }
                }
                // Allocate Subject to Standard
                if(userInput=="ss")
                {
                    Console.WriteLine("Enter SubjectID");
                    string subjectidinput = Console.ReadLine();
                    long subjectId = Convert.ToInt64(subjectidinput);

                    Console.WriteLine("Enter StandardID");
                    string standardidinput = Console.ReadLine();
                    long standardId = Convert.ToInt64(standardidinput);
                    
                    bool success = theSchool.AllocateSubjectToStandard(subjectId,standardId);
                    if(success) 
                    {
                        Console.WriteLine("Subject has been allocated to Standard");
                    } 
                    else 
                    {
                        Console.WriteLine("Please enter correct value");
                    }
                }
                // Quit
                if(userInput=="q")
                {
                    break;
                }
            
            }

            // end

        }
    }
}
