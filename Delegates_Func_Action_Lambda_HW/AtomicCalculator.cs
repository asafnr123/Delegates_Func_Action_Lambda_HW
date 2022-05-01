using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Func_Action_Lambda_HW
{
    internal class AtomicCalculator
    {
        public double X { get; private set; }
        public double Y { get; private set; }

        public Func<double> GetNumberFromUser { get; set; }
        public Action MenuPrinter { get; set; }
        public Func<int> GetUserChoice { get; set; }
        public Func<double, double, int, double> Calculate { get; set; }    
        public Action<double> ResultPrinter { get; set; }





        public void Run()
        {
            //Getting numbers from user
            X = GetNumberFromUser();
            Y = GetNumberFromUser();

            //Printing the Menu
            MenuPrinter.Invoke();

            //Get user operator
            int userChoice = GetUserChoice.Invoke();

            double result = Calculate.Invoke(X, Y, userChoice);

            ResultPrinter.Invoke(result);
        }
    }
}
