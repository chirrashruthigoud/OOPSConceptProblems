using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConceptProblems
{
    public abstract class Abstraction
    {
        public abstract void Mul(int x, int y);
        public abstract void Div(int x, int y);


        public void Sub(int x,int y)
        {
            Console.WriteLine(x-y);
        }
        public void Sum(int x, int y )
        {
            Console.WriteLine(x+y);
        }

    }
}
