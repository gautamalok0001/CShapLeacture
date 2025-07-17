using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelProgramming.OopsConcept.Inheritance
{
    //Multilevel Inheritance, Multiple Inheritance
    //While using the class we can't achive the multiple inheritance

   //Multilevel Inheritance we can achieve through the Class
   //C# we can achieve it through the class and interface
    public class FirstChild
    {

    }
    public class SecondChild  : FirstChild
    { 
    
    }
    public class DerivedClass : SecondChild
    {
    }

    //While using the class we can't achive the multiple inheritance
    //Problem
    //public class Parent : FirstChild, SecondChild
    //{
    //}
    //We can achieve multiple inheritance through the interface
    //We can't achieve it through the class
    public class Parent : IFirstChild, ISecondChild
    {
        public void GetFirstName()
        {
            throw new NotImplementedException();
        }

        public void GetSecondName()
        {
            throw new NotImplementedException();
        }
    }

}
