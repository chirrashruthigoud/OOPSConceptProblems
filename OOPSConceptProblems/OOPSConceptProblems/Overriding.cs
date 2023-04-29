using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConceptProblems
{
    public class Overriding
    {
        // Example of method overriding
      
            public virtual void MakeSound()
            {
                Console.WriteLine("The animal makes a sound");
            }
        }

        class Dog : Overriding
    {
            public override void MakeSound()
            {
                Console.WriteLine("The dog barks");
            }
        }
       class Shape
        {
            public virtual void Draw()
            {
                Console.WriteLine("Drawing a shape");
            }
        }
        class Circle : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Drawing a circle");
            }
        }
    }