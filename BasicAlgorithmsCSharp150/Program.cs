using System;
using System.Text;

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

            /*
                Exercise 6
                ***************************************************************************************** 
                Write a C# Sharp program to remove the character in a given position of a given string. 
                The given position will be in the range 0.. string length -1 inclusive.
            */
            // SolveExerciseSix();

            /*
                Exercise 7
                ***************************************************************************************** 
                Write a C# Sharp program to exchange the first and last characters in a given string and return the new string.
            */
            // SolveExerciseSeven();
            // SolveExerciseSevenOnAnotherWay


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
            int userInput;
            Console.WriteLine("Please enter a number: ");
            while (!int.TryParse(Console.ReadLine(), out userInput))
            {
                Console.WriteLine("Invalid input, please try again");
            }

            Console.WriteLine( Math.Abs(number1 - userInput) <= 10 ||
                                Math.Abs(number2 - userInput) <= 10 );
        }

        public static void SolveExerciseFive()
        {
            Console.WriteLine("Enter a string");
            string userInput = Console.ReadLine();

            Console.WriteLine("Output is: {0}", userInput.ToLower().StartsWith("if") ? userInput : userInput.Insert(0, "if "));
        }

        public static void SolveExerciseSix()
        {
            int removedCharactersCount = 1;
            int position;
            Console.WriteLine("Enter a string:");
            string userText = Console.ReadLine();
            Console.WriteLine("Enter the position that you want to remove... start from 0");

            while (!int.TryParse(Console.ReadLine(), out position) || position > userText.Length - 1 || position < 0)
            {
                Console.WriteLine("Invalid position...please try again");
            }

            Console.WriteLine("New Text is: {0}", userText.Remove(position, removedCharactersCount));
        }

        public static void SolveExerciseSeven()
        {
            Console.WriteLine("Enter a string: ");
            var userInput = Console.ReadLine();

            var StartTime = DateTime.Now;

            if(userInput.Length < 2)
            {
                Console.WriteLine("Result is: {0}", userInput);
                return;
            }

            var firstLetter = userInput[0];
            var lastLetter = userInput[userInput.Length - 1];

            
            Console.WriteLine("Result is: {0}", lastLetter + userInput.Substring(1, userInput.Length - 2) + firstLetter);

            var EndTime = DateTime.Now;
            Console.WriteLine("Execution Time is: {0}", (EndTime - StartTime));
        }

        public static void SolveExerciseSevenOnAnotherWay()
        {
            Console.WriteLine("Enter a string: ");
            var userInput = Console.ReadLine();

            var StartTime = DateTime.Now;

            if (userInput.Length < 2)
            {
                Console.WriteLine("Result is: {0}", userInput);
                return;
            }

            int middleStringLength = userInput.Length - 1;
            StringBuilder input = new StringBuilder();
            
            input.Append(userInput[middleStringLength]);
            for (int i = 1; i < middleStringLength; i++)
            {
                input.Append(userInput[i]);
            }
            input.Append(userInput[0]);

            Console.WriteLine("Result is: {0}", input);

            var EndTime = DateTime.Now;
            Console.WriteLine("Execution Time is: {0}", (EndTime - StartTime));
        }
    }
}
