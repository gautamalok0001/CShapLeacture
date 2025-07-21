namespace ParallelProgramming.OopsConcept.ClassTypes
{
    //Compile time and runtime
    public static class StaticClass
    {
        public static void GetName()
        {

        }
    }
    //You can't derived the sealed class
    public sealed class SealedClass
    {
        public void GetName() { }
    }
    //You can't create the instance of abstract class
    public abstract class AbstractClass
    {
    }

    //combine all their properties //can allow duplicate members 
    public partial class PartialClass
    {
        public void GetName() { }

    }

    
    public class NormalClass : AbstractClass
    {
        public void GetName()
        {

        }
    }

    public partial class PartialClass
    {
        public void GetFirstName()
        {

        }
        public void GetLastName() 
        {
            
        }
    }
    
}
