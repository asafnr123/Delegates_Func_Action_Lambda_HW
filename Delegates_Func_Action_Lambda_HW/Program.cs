using System;

namespace Delegates_Func_Action_Lambda_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SimpleCalculator c = new SimpleCalculator();

            c.PrintMenu();
            //Console.WriteLine(c.NumberGetter()); 
        }
    }
}
