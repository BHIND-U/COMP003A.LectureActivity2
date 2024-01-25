﻿/* Author: Joshua Isidro   
 * Course: COMP-003A
 * Purspose: Code for COMP003A.LectureActivity2
 * Reference: The C# Player's Guide (4e) by RB Whitaker 
 */

namespace COMP003A.LectureActivity2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string username;
            Console.WriteLine("What is your name?");
            username = Console.ReadLine();
            Console.WriteLine("Hi " + username);


            string favoriteColor;
            Console.WriteLine("What is your favorite color?");
            favoriteColor = Console.ReadLine();
            Console.WriteLine("Your favorite color is" + favoriteColor);


            int score;
            score = 0;
            score = 4;
            score = 11;
            score = -1564;


            int a;
            int b;


            a = 5;
            b = 2;
            Console.WriteLine("The current value of a:" + a);
            Console.WriteLine("The current value of b:" + b);


            b = a;
            a = -3;
            Console.WriteLine("The new value of a:" + a);
            Console.WriteLine("The current value of b:" + b);

            string exampleVariable;
            string exampleVAriable;
            string exampleVARiable;


            Console.WriteLine("********************************************************");


            byte aSingleByte = 34;
            Console.WriteLine("aSingleByte" + aSingleByte);
            aSingleByte = 17;
            Console.WriteLine("aSingleByte" + aSingleByte);


            short aNumber = 5039;
            Console.WriteLine("aNumber: " + aNumber);
            aNumber = -4354;
            Console.WriteLine("aNumber: " + aNumber);

            long aVeryBigNumber = 395905282569;
            Console.WriteLine("aVeryBigNumber:" + aVeryBigNumber);
            aVeryBigNumber = 13;
            Console.WriteLine("aVeryBigNumber:" + aVeryBigNumber);

            double number1 = 3.5623;
            float number2 = 3.5623;
            decimal number3 = 3.5623m;
            Console.WriteLine($"Value of number1: {number1}");
            Console.WriteLine($"Value of number2: {number2}");
            Console.WriteLine($"VAlue of number3: {number3}");

            double avogadrosNumber = 6.022e23;
            Console.WriteLine($"Value of avogadrosNumber:{avogadrosNumber}");



            bool itWorked = true;
            Console.WriteLine($"Value of itWorked: {itWorked}");
            itWorked = false;
            Console.WriteLine($"New Value of itWorked: {itWorked}");

            string inputeAgeString;
            int inputAge;
            int currentYear = 2023;
            Console.WriteLine($"Enter age in {currentYear}:");
            inputeAgeString = Console.ReadLine();
            inputAge = Convert.ToInt32(inputeAgeString);
            Console.WriteLine($"Your age is {inputAge}");



            Console.WriteLine("********************************************************");


            int addition = 2 + 3;
            int subtraction = 5 - 2;
            int multiplication = 22 * 2;
            int division = 21 / 7;
            int modulo = 77 % 5;
            Console.WriteLine($"Value of addition: {addition}");
            Console.WriteLine($"Value of subtraction: {subtraction}");
            Console.WriteLine($"Value of multiplication: {multiplication}");
            Console.WriteLine($"Value of modulo: {modulo}");



            int arithmetic1;
            arithmetic1 = 9 - 2;
            Console.WriteLine($"Value of arthmetc1: {arithmetic1}");
            arithmetic1 = 3 + 3;
            Console.WriteLine($"New Value of arithmetic1: {arithmetic1}");
            int arithmetic2 = 3 + 1;
            Console.WriteLine($"Value of arithmetic2: {arithmetic2}");
            arithmetic2 = 1 + 2;
            Console.WriteLine($"New value of arithmetic2: {arithmetic2}");

            int result = ((2 + 1) * 8 - (3 * 2) * 2) / 4;
            Console.WriteLine($"Value of result: {result}");

            int compoundAssignmnetOperator = 0;
            compoundAssignmnetOperator += 5;
            compoundAssignmnetOperator -= 2;
            compoundAssignmnetOperator *= 4;
            compoundAssignmnetOperator /= 2;
            compoundAssignmnetOperator %= 2;

            int incrementDecrementOperators = 0;
            incrementDecrementOperators++;
            incrementDecrementOperators--;

            Console.WriteLine("*************************************************************");

            Console.WriteLine("What is your name, human?");
            string userName = Console.ReadLine();

            Console.WriteLine("Press any key when yo're ready to begin.");
            Console.ReadKey();

            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Title = "Hello World";
            Console.Beep(440,1000);









        }
    }
}
