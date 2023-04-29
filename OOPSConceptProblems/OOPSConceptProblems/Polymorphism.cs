using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConceptProblems
{// polymorphism means  many form and there are two types of polymorphism
    //Run-time polymorphism =>method overriding
    //Compile type polymorphism =>method overloading
    public class Polymorphism
    {
        public void overloading(int a, string s)
        {
            
           Console.WriteLine($"with parameters: {a+s}");
        }
        public int Sum(int a, int b)
        {
            return a + b;
        }
        public double Add(double a, double b)
        {
            return a + b;
        }
        public void Withoutpara()
        {
            int a = 77;
            int b = 99;
            Console.WriteLine($"without parameters : {a - b}");
        }

    }
}
