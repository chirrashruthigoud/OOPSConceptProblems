using OOPSConceptProblem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConceptProblems
{
    //interface is like abstract class
    //we cannot create object for an interface
    //the private members are not allowed in the interface
    //by default interface members are abstract public
    public interface Interface
    { //does not have any body.
        void Move();
    }

    public class DogAnimal : Interface
    {
        public void Move()
        {
            Console.WriteLine("The dog is running.");
        }
    }

    public class Cat : Interface
    {
        public void Move()
        {
            Console.WriteLine("The cat is walking.");
        }
    } 
}