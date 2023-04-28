using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConceptProblems
{
    public class Inheritance
    {
        public int Id;
        public string Name,Address, Phone;
        public void Method() 
        {
            // Console.WriteLine(Id + " "  + Name + " " + Address + " " + Phone);
            Console.WriteLine("Id number:" + Id);
            Console.WriteLine("Name :" + Name);
            Console.WriteLine("Address:" + Address);
            Console.WriteLine("Phone No :" + Phone);
        }
    }
    public class Student:Inheritance
    {
        public int Class;
        public char Grade;
       public float Marks, Fees;

        public void ClassMethod()
        {
           // Console.WriteLine(Class + " " + Grade + " " +Marks + " " + Fees);
            Console.WriteLine("Class Name :" + Class);
            Console.WriteLine("Grade :" + Grade);
            Console.WriteLine("Marks : " + Marks);   
            Console.WriteLine("Fees : " + Fees);
        }
    }
    public class Staff:Inheritance
    {
        public double Salary;
        public string Designation;

        public void StaffMethod()
        {
            Console.WriteLine("Salary of staff:" + Salary);
            Console.WriteLine("Designation :" +Designation);
        }
    }
    public class Teaching:Staff
    {
        public string Qualification,Subject;
        public void TeachingMethod()
        {
            Console.WriteLine("Qualification of teacher :" + Qualification);
            Console.WriteLine("Subject of teacher :" + Subject);
        }
    }
    
}
