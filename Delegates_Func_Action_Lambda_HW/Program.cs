using System;

namespace Delegates_Func_Action_Lambda_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SimpleCalculator c = new SimpleCalculator();
            AtomicCalculator ac = new AtomicCalculator();

            ac.GetNumberFromUser = c.NumberGetter;
            ac.MenuPrinter = c.PrintMenu;
            ac.GetUserChoice = c.GetUserChoice;
            ac.Calculate = c.Calculator;
            ac.ResultPrinter = c.PrintResultNicely;
            ac.ResultPrinter += (result => Console.WriteLine($"{result} from lambda"));

            ac.Run();
            
        }
    }
}
