using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConceptProblems
{
    public class Reference
    {
        public void ReferenceMethod()
        {
            int num = 10;
            int num_one = num;
            int sum = num * num_one;
            Console.WriteLine("number :" + num);
            Console.WriteLine("reference number :" + num_one);
            Console.WriteLine("sum is :" + sum);           
        }
        public void referenceMethod(ref int num)
        {
            num=num*num;
            Console.WriteLine(num);
        }
    }
}
