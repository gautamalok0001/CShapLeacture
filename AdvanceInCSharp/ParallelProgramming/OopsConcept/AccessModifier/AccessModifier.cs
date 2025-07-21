namespace ParallelProgramming.OopsConcept.AccessModifier
{
    //public, private, internal, protected, private protected, protected internal

    //Public - It can access inside the same library and out side of the library with in same solution
    public class Employee
    {
       
        private string Name { get; set; }  //only access inside of the same class 
        internal string SecondName { get; set; }  //Internal can only access inside of the same class library
        private protected string LastName { get; set; } //only access from the same class library derived class
        public string FirstName { get; set; }
        protected string Address { get; set; }  //Protected member can access from the derived classes //same library or different library

        //Private memeber can access only inside of the class File
        public string GetFullName()
        {
            return Name;
        }

    }

    //public or internal
    internal class Manager
    {
        private string Name { get; set; }
        internal string SecondName { get; set; }
        private protected string LastName { get; set; }

        public string GetManagerName()
        {
            Employee employee = new Employee();
            employee.SecondName = SecondName;
            employee.FirstName = Name;

            employee.GetFullName();
            return "";
        }

    }

    public class Boss : Employee
    {
        private string Address { get; set; }    
        public string GetBoss()
        {
            Boss boss = new Boss();
            boss.Address = Address;  //Here I can access the address class memeber
            boss.LastName = LastName; //Here I can access the address class memeber
            return "";
        }
       
       
    }
} 
