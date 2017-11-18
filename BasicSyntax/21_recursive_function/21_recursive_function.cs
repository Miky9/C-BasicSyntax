using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
///A recursive function is a function that calls itself.

//0!=1  1!=1


namespace _21_recursive_function
{
    //Program to compute factorial of a number without using recursion.
    //public class Program
    //{
    //    public static void Main()
    //    {
    //        // Prompt the user to enter a number
    //        Console.WriteLine("Please enter a number");
    //        // Read the number from the console and convert to int
    //        int userNumber = Convert.ToInt32(Console.ReadLine());
    //        // Call Factorial function and pass the user entered number to it
    //        double factorial = Factorial(userNumber);
    //        // Print the factorial
    //        Console.WriteLine("Factorial of " + userNumber.ToString() + " = " + factorial.ToString());
    //    }

    //    public static double Factorial(int number)
    //    {
    //        // ZERO factorial is 1, so return 1 if number is ZERO.
    //        if (number == 0)
    //            return 1;

    //        double factorial = 1;

    //        // Compute the factorial using a for loop
    //        for (int i = number; i >= 1; i--)
    //        {
    //            factorial = factorial * i;
    //        }

    //        // return the factorial of the number
    //        return factorial;
    //    }
    //}

    //Program to compute factorial of a number with recursion.
    public class Program
    {
        public static void Main()
        {
            // Prompt the user to enter a number
            Console.WriteLine("Please enter a number");
            // Read the number from the console and convert to int
            int userNumber = Convert.ToInt32(Console.ReadLine());
            // Call Factorial function and pass the user entered number to it
            double factorial = Factorial(userNumber);
            // Print the factorial
            Console.WriteLine("Factorial of " + userNumber.ToString() + " = " + factorial.ToString());
        }

        public static double Factorial(int number)
        {
            // ZERO factorial is 1, so return 1 if number is ZERO.
            if (number == 0)
                return 1;

            // Notice that the Factorial method is calling itself here
            return number * Factorial(number - 1);
        }
    }

}
