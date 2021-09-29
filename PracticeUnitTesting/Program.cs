using System;

namespace PracticeUnitTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to unit testing");
            SimpleCalc simpleCalc = new SimpleCalc();
            Console.WriteLine(simpleCalc.addFun(5, 6));
            Console.WriteLine(simpleCalc.subFun(5, 6));
            Console.WriteLine(simpleCalc.divFun(5, 3));
            Console.WriteLine(simpleCalc.mulFun(5, 6));
        }
    }
}