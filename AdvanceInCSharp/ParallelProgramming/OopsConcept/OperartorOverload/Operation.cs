namespace ParallelProgramming.OopsConcept.OperartorOverload
{
    public class Operation
    {
        public int num { get; set; }
        public Operation(int num)
        {
            this.num = num;
        }
        public  static Operation operator + (Operation op1, Operation op2){
            return new Operation(op1.num + op2.num);
        }
        public static Operation operator -(Operation op1, Operation op2)
        {
            return new Operation(op1.num - op2.num);
        }

    }
}
