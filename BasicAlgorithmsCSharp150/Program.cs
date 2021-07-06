using System;

namespace BasicAlgorithmsCSharp150
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Exercise 1 
                ***************************************************************************************** 
                Write a C# Sharp program to compute the sum of the two given integer values. 
                If the two values are the same, then return triple their sum.
            */
            // SolveExerciseOne();

            /*
                Exercise 2
                ***************************************************************************************** 
                Write a C# Sharp program to get the absolute difference between n and 51. 
                If n is greater than 51 return triple the absolute difference
            */
            // SolveExerciseTwo();
        }
        public static void SolveExerciseOne()
        {
            int number1, number2, result;

            while (true)
            {
                Console.WriteLine("Enter the first number: ");
                var number1Val = int.TryParse(Console.ReadLine(), out number1);
                Console.WriteLine("Enter the second number: ");
                var number2Val = int.TryParse(Console.ReadLine(), out number2);

                if (number1Val && number2Val)
                {
                    break;
                }
                Console.WriteLine("Invalid Input");
            }

            result = (number1 == number2) ? (number1 * 6) : (number1 + number2);
            Console.WriteLine("Result is {0}", result);
        }

        public static void SolveExerciseTwo()
        {
            const int number = 51;
            int userNumber;

            Console.WriteLine("Enter a number");

            while(!int.TryParse(Console.ReadLine(), out userNumber))
            {
                Console.WriteLine("Invalid Input, try again");
            }

            int result = (number > userNumber) ? (number - userNumber) : (userNumber - number) * 3;
            Console.WriteLine("The difference is {0}", result);
        }
    }
}
