using OOPSConceptProblems;
using System.Security.Principal;

namespace OOPSConceptProblem
{
    public class Program : Inheritance
    {
        public static void Main(string[] args)
        {
            /* Methods obj= new Methods();
             obj.Parameterizedmethod("sara",24);
             obj.Addmethod(2,5);
             obj.Nonparameterized();*/


            /* ClassandObject name = new ClassandObject();
             name.TVname = "LG";
             name.cost = 98000;
             name.classandObject();

             ClassandObject name_one = new ClassandObject();
             name_one.TVname = "Sony";
             name_one.cost = 67000;
             name_one.classandObject();*/

            /* Student obj =new Student();
             obj.Id = 1;
             obj.Name = "sai";
             obj.Address = "Hyd";
             obj.Phone = "9876545785";
             obj.Method();
              obj.Class = 1;
             obj.Grade = 'A';
             obj.Marks = 554;
              obj.Fees = 22000;
             obj.ClassMethod();
             Console.ReadLine();

             Staff obj_one=new Staff();
             obj_one.Salary = 23000;
             obj_one.Designation = "MathTeacher";
             obj_one.StaffMethod();

             Teaching name = new Teaching();
             name.Id = 2;
             name.Name = "pari";
             name.Address = "AP";
             name.Phone = "9865456658";
             name.Method();
             name.Salary = 12000;
             name.Designation = "MT";
             name.StaffMethod();
             name.Subject = "Maths";
             name.Qualification = "Ms";
             name.TeachingMethod();*/

            //Encapsulation

            Encapsulation num = new Encapsulation();
            /* num.SetAccountNum =456855276;
             Console.WriteLine(num.SetAccountNum);*/

            num.setAccount(579876687);
            Console.WriteLine("Account number : " + num.getAccount());

        }
    }
}