using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Func_Action_Lambda_HW
{
    internal class SimpleCalculator
    {



        public double NumberGetter()
        {
            double userNumber = 0;
            Console.Write("Enter a number: ");
            try
            {
                userNumber = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a number");
                return NumberGetter();
            }
            
            if (userNumber <= 0)
            {
                Console.WriteLine("Please choose a positive number");
                return NumberGetter();
            }

            return userNumber;
           
        }


        public void PrintMenu()
        {
            Console.WriteLine("***Choose an operator***");
            Console.WriteLine("1) + \n" +
                "2) - \n" +
                "3) * \n" +
                "4) / \n");
        }


        public int GetUserChoice()
        {
            Console.Write("Choose a number from 1 - 4: ");
            int userChoice = 0; 
            try
            {
                userChoice = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a number");
                return GetUserChoice();
            }

            if (userChoice < 1 || userChoice > 4)
                return GetUserChoice();

            return userChoice;

        }


        public double Calculator(double num1, double num2, int oper)
        {
            double result = 0;
            switch (oper)
            {
                case 1:
                    {
                        Console.WriteLine($"{num1} + {num2}");
                        result = num1 + num2;
                        return result;
                    }
                case 2:
                    {
                        Console.WriteLine($"{num1} - {num2}");
                        result = num1 - num2;
                        return result;
                    }
                case 3:
                    {
                        Console.WriteLine($"{num1} * {num2}");
                        result = num1 * num2;
                        return result;
                    }
                case 4:
                    {
                        Console.WriteLine($"{num1} / {num2}");
                        result = num1 / num2;
                        return result;
                    }

                    default:
                    {
                        Console.WriteLine("Something went wrong");
                        return 0;
                    }

            }
        }

        public void PrintResultNicely(double result)
        {
            Console.WriteLine($"**{result}**");
        }


    }
}
