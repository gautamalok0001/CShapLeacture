using ParallelProgramming.OopsConcept.ClassTypes;
using ParallelProgramming.OopsConcept.OperartorOverload;
using ParallelProgramming.OopsConcept.Polymorphism;
using ParallelProgramming.Statement;

public class Program
{
    static async Task Main()
    {
        //RefKeyword keyword = new RefKeyword();
        //keyword.RefIterator();
        //DictionaryPractice dictionary = new DictionaryPractice();
        //dictionary.ConcurrentDictionary();

        //IntOne typesOfClass = new TypesOfClass();
        //typesOfClass.GetName();

        //Operation in1 = new Operation(5);
        //Operation in2 = new Operation(6);
        //Operation sum = in1 + in2;

        //ClassOverride4 classOverride4 = new ClassOverride4();
        //classOverride4.GetName();

        //ClassOverride3 classOverride3 = new ClassOverride4();
        //string result = classOverride3.GetName();

        //ClassOverride classOverride = new ClassOverride();
        //string result = classOverride.GetName();

        NormalClass normalClass = new NormalClass();
        normalClass.GetName();

        //StaticClass staticClass = new StaticClass(); //Can't create the instance
        StaticClass.GetName(); //Common use where we are not making any kind of data manipulation and cpu calculation where instance not needed

        AbstractClass abstractClass = new NormalClass();

        PartialClass partialClass = new PartialClass();
        partialClass.


    }

    //static async Task Main()
    //{
    //    var account = new Account(1000);
    //    var tasks = new Task[100];
    //    for (int i = 0; i < tasks.Length; i++)
    //    {
    //        tasks[i] = Task.Run(() => Update(account));
    //    }
    //    await Task.WhenAll(tasks);
    //    Console.WriteLine($"Account's balance is {account.GetBalance()}");
    //Output:
    //    Account's balance is 2000
    //}

    //static void Update(Account account)
    //{
    //    decimal[] amounts = [0, 2, -3, 6, -2, -1, 8, -5, 11, -6];
    //    foreach (var amount in amounts)
    //    {
    //        if (amount >= 0)
    //        {
    //            account.Credit(amount);
    //        }
    //        else
    //        {
    //            account.Debit(Math.Abs(amount));
    //        }
    //    }
    //}

}