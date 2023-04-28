using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConceptProblems
{
    public class Methods
    {
        
        public void Parameterizedmethod(String name, int age)
        {
            string add = name + age;

            Console.WriteLine(name + "," + age);
        }
        public void Addmethod(int a, int b)
        {
            int add = a + b;
            int mult = a - b;
            Console.WriteLine("Number :" + add );
            Console.WriteLine("Number :" +mult);
        }
        public void Nonparameterized()
        {
            int a = 60; int b = 6;
            int div = a/b;
            Console.WriteLine(div);
            Console.WriteLine("shruthi");

        }

    }
}
