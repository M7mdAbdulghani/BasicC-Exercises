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


            /*
                Exercise 3
                ***************************************************************************************** 
                Write a C# Sharp program to check two given integers, and return true if one of them is 30 or if their sum is 30
            */
            // SolveExerciseThree();

            /*
                Exercise 4
                ***************************************************************************************** 
                Write a C# Sharp program to check a given integer and return true if it is within 10 of 100 or 200.
            */
            // SolveExerciseFour();

            /*
                Exercise 5
                ***************************************************************************************** 
                Write a C# Sharp program to create a new string where 'if' is added to the front of a given string. 
                If the string already begins with 'if', return the string unchanged.
            */
            // SolveExerciseFive();

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

        public static void SolveExerciseThree()
        {
            int number1, number2;
            bool number1Val, number2Val, result;

            while (true)
            {
                Console.WriteLine("Enter the first number: ");
                number1Val = int.TryParse(Console.ReadLine(), out number1);
                Console.WriteLine("Enter the second number: ");
                number2Val = int.TryParse(Console.ReadLine(), out number2);

                if(number1Val && number2Val)
                {
                    break;
                }
                Console.WriteLine("Invalid input");
            }

            Console.WriteLine("Result is {0}", (number1 == 30 || number2 == 30 || number1 + number2 == 30));
        }

        public static void SolveExerciseFour()
        {
            const int number1 = 100;
            const int number2 = 200;
            const int StaticValue = 10;
            int userInput;
            Console.WriteLine("Please enter a number: ");
            while (!int.TryParse(Console.ReadLine(), out userInput))
            {
                Console.WriteLine("Invalid input, please try again");
            }

            Console.WriteLine(( (number1 - userInput <= 10 && number1 - userInput >= 0) || (userInput - number1 <= 10 && userInput - number1 >= 0) ||
                                (number2 - userInput <= 10 && number2 - userInput >= 0) || (userInput - number2 <= 10 && userInput - number2 >= 0) ));
        }

        public static void SolveExerciseFive()
        {
            Console.WriteLine("Enter a string");
            string userInput = Console.ReadLine();

            Console.WriteLine("Output is: {0}", userInput.ToLower().StartsWith("if") ? userInput : userInput.Insert(0, "if "));
        }
    }
}
