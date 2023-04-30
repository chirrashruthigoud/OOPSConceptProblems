using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConceptProblems
{
    public class ConstructorTypes
    {
        public string name;
        public int number;
        public ConstructorTypes()
        {
          
            int a = 10;
            int b = 20;
            Console.WriteLine($"number is : {a+b}");
        }
        
        public ConstructorTypes(int a, int b)
        {
            
            Console.WriteLine($"sub the numbers : {a-b}");
        }
       
    }
}
