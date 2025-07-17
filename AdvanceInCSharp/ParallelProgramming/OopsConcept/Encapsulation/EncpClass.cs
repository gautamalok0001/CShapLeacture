namespace ParallelProgramming.OopsConcept.Encapsulation
{
    public class EncpClass : IEnc
    {
        //Implemetation
        public string GetName(string firstName, string lastName)
        {
            return firstName + " " + lastName;
        }
    }
}
