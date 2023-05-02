using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConceptProblems
{
    public class accessmodifiers
    {
        //consuming members of a class from same class and child class of same project(accessed anywhere in the project only)
        internal void test1()
        {
            Console.WriteLine("internal ");
        }
        //consuming members of a class from the class
        private void test2()
        {
            Console.WriteLine("private ");

        }
        //consuming members of a class from same class and child class(accessed with in the class as well as with in child class)
        protected void test3()
        {
            Console.WriteLine("protected ");

        }
        //consuming members of a class with in the class and child class in different Project
        protected internal void test4()
        {
            Console.WriteLine("protected internal ");

        }
        //consuming members of a class everywhere

        public void test5()
        {
            Console.WriteLine("public ");

        }
      /*  static void Main(string[] args)
        {
            accessmodifiers p = new accessmodifiers();
            p.test1(); p.test2(); p.test3(); p.test4(); p.test5();

        }*/
    }
}
