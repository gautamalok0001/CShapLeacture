using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelProgramming.OopsConcept.Polymorphism
{
    public class ClassOverride
    {
        public virtual string GetName()
        {
            return "Hi My Name is Thor!";
        }
    }
    public class ClassOverride2 : ClassOverride
    {
        public override string GetName()
        {
            return "Hi My Name is Luca!";
        }
    }
    public class ClassOverride3 : ClassOverride2
    {
        public new string GetName()
        {
            return "Hi name is Zela!";
        }
    }
    public class ClassOverride4 : ClassOverride3
    {
        public new string GetName()
        {
            return "Hi name is Maya";
        }
    }

    //Method overloading //Method overriding
    //One method in many form
    //Method Overloading //Will explain Compile and //runtime

    //Method Overloading 
    public class MethodOverloading  //Parent 
    {

        public string GetName()  //Parameter less method
        {
            return "Default Name";

        }
        //Independent of their return type //Case 1
        public bool GetName(string name) //name as an input parameter
        {
            return false;
        }
        public bool GetName(string name, string secondName) //name as an input parameter
        {
            return false;
        }

        //Still will give you the compile time error, aleady the method exist with the Same method and parameter. It is independent of return type
        //public string GetName(string name) //name as an input parameter
        //{
        //    return name;
        //}
        //This will give compile time error because the same method signature already exist
        //public string GetName(string name) //name as an input parameter
        //{
        //    return name;
        //}
        //This will treated as a case 1 if you pass the name as a default parameter
        //public string GetName(string name = "default")
        //{
        //    return name;
        //}
    }

    public class Parent
    {

    }

    public class Child : Parent
    {
        //Inheriting the parent class Properties
    }


    public class MethodOveriding
    {
        public virtual void GetName(string name)
        {

        }
    }

    public class OverrideDerivedClass : MethodOveriding
    {
        public override void GetName(string name)
        {

        }
    }

    public class DerivedClass : MethodOverloading
    {
       
    }

    public class Test
    {
        public void Func()
        {
            DerivedClass derivedClass = new DerivedClass();//Instance of the derived class
            derivedClass.GetName();

            MethodOverloading methodOverloading = new DerivedClass();
            methodOverloading.GetName();

            MethodOverloading overloading = new MethodOverloading();
            overloading.GetName();

            OverrideDerivedClass overrideDerived = new OverrideDerivedClass();
            overrideDerived.GetName("test");



        }
    }

}




