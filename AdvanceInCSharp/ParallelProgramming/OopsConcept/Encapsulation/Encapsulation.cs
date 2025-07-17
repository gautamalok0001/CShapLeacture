using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelProgramming.OopsConcept.Encapsulation
{
    public class Encapsulation
    {

        public void Func()
        {
            IEnc _enc = new EncpClass();
            //We don't about about how the result formed only we got the result 
            //This is coming as a part of encapsulation
            string result = _enc.GetName("Rakesh", "Roshan"); //Rakesh Roshan  
        }
    }
}
