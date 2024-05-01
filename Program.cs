using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Numerics;
using System.Runtime.CompilerServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assign_Conditions_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Carla Baysinger
            // Assignment Conditions and Loops
            // April 29th 2024

            Menu();
            PositiveNegativeorZero();
            LargestofThree();
            CheckForAVowel();
            MultiplicationTable();
            CheckIfANumberIsPrime();
            FizzBuzz();

        }

        public static void PositiveNegativeorZero()
        {
            Console.WriteLine("Enter a number: "); //asked the user for a number
            int num = int.Parse(Console.ReadLine()); //computer reads number
            bool positive = num > 0; // use bool to determine if the number is positive, negative, or zero
            bool negative = num < 0;
            bool zero = num == 0;
            if (positive) // if the number is a positive number
            {
                Console.WriteLine($"Enter a number: {num}");
                Console.WriteLine("positive"); //display positive
            }

            else if (negative) //if the number is negative
            {
                Console.WriteLine($"Enter a number: {num}");
                Console.WriteLine("negative"); // display negative
            }
            else if (zero) //if the number is zero
            {
                Console.WriteLine($"Enter a number: {num}");
                Console.WriteLine("zero"); //display zero
            }
            else
            {
                Console.WriteLine("invalid"); //if anything else it displays invalid
            }

        }//PositiveNegativeorZero()


        public static void LargestofThree()
        {
            //Task: Write a program to take three different numbers as input.Determine the largest of the three numbers and display it.
            Console.WriteLine("Enter 1st number: "); //ask user for number
            string userInput = Console.ReadLine(); //Convert to string
            int num1 = int.Parse(userInput); // convert string to int
            Console.WriteLine("Enter 2nd number: "); //ask user for number 2
            userInput = Console.ReadLine(); 
            int num2 = int.Parse(userInput); //convert to int
            Console.WriteLine("Enter 3rd number: ");
            userInput = Console.ReadLine();
            int num3 = int.Parse(userInput);
            

            if (num1 > num2) // checking if number 1 is bigger than number2
            {
                if(num1 > num3) // checking if number 1 is greater than number 3
                {
                    Console.WriteLine("The 1st number is largest among the three"); //display
                }
                else
                {
                    Console.WriteLine("The 3rd number is the largest among the three");//display
                }

            }
            else if(num2 > num3) //if number 2 is greater than number 3
            {
                Console.WriteLine("The 2nd number is the largest among the three");
            }
            else
            {
                Console.WriteLine("The 3rd number is the greatest among the three");
            }
            


        } // LargestofThree()


        public static void CheckForAVowel()
        {
            // Task: Write a program that takes an alphabet as input.Check whether the input is a vowel (a, e, i, o, u) or a consonant.

            Console.Write("Enter a character: ");
            string userResponse = Console.ReadLine();


            if (userResponse == "a" || userResponse == "e" || userResponse == "i" || userResponse == "o" || userResponse == "u")
            {
                Console.WriteLine("vowel");
            }
           
            else if (userResponse == "A" || userResponse == "E" || userResponse == "I" || userResponse == "O" || userResponse == "U")
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("consonant");
            }

        } //CheckForAVowel()
        
        public static void MultiplicationTable()
        {
            //Task: Write a program to print the multiplication table of a given number up to 10. Ask the user for a number, then print out the related multiplication table.
           
            Console.WriteLine("Enter a number: "); // asked user for number
            string userInput = Console.ReadLine(); // reads as string
            int num = int.Parse(userInput); // converted to int
            int j; // declared a variable
                      
                for (j = 1; j <= 10; j++) // used for loop to determine multication table
                {
                Console.Write("{0} X {1} = {2} \n", num, j, num * j); // display multiplication table

                }                
                      
        } // /MulticationTable()

        public static void CheckIfANumberIsPrime()
        {
            //Task: Write a program to determine if a given number is a prime number(a number only divisible by 1 and itself).
            Console.WriteLine("Enter a number: ");
            string userInput = Console.ReadLine();
            int num = int.Parse(userInput);

            int a = 0;

                for (int i = 1; i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        a++;
                    }
                }
                if (a == 2)
                {
                    Console.WriteLine("{0} is a Prime Number", num);
                }
                else
                {
                    Console.WriteLine("Not a Prime Number");
                }
        } // CheckIfANumberIsPrime()

        public static void FizzBuzz()

        {
            //Task: Write a program that prints the numbers from 1 to 100.
            //For multiples of three, print "Fizz" instead of the number.
            //For multiples of five, print "Buzz".
           // For numbers that are multiples of both three and five, print "FizzBuzz".


            for (int i = 1; i <= 100; i ++) // how to display numbers 1 to 100
            {
                if (i % 3 == 0 & i % 5 == 0) // if multiples of bothe 3 and 5
                {
                    Console.WriteLine("FizzBuzz"); // display this
                }
                else if (i % 3 == 0) // if multiples of three
                {
                    Console.WriteLine("Fizz"); // display for multiples of three
                }
                else if (i % 5 == 0) // if multiples of five
                {
                    Console.WriteLine("Buzz"); // display
                }
                
                else
                {
                    Console.WriteLine(i); // display numbers besides above
                }
            }
            
        
           
        } // FizzBuzz()

        public static void Menu()
        {
            //Create a menu structure that lets the user choose conditions or loops. Then a sub menu that lets the user choose which of the questions to try. ( This will use a next if / else structure ). This menu is designed to loop until the user wants to exit.
            bool isRunning = true;

            do
            {
                Console.WriteLine("1 - Conditional Questions");
                Console.WriteLine("2 - Loop Questions");
                Console.WriteLine("3 - Exit");
                string userResponse = Console.ReadLine();

                // Conditional Questions
                if (userResponse == "1")
                {

                    Console.WriteLine("1 - Positive, Negative, or Zero");
                    Console.WriteLine("2 - Largest of Three");
                    Console.WriteLine("3 - Check for a vowel");
                    Console.WriteLine("Press any other key to go back to the menu");
                    userResponse = Console.ReadLine(); // Notice reusing our userResponse variable

                    if (userResponse == "1")
                    {
                        // Call Problem 1 Method
                        PositiveNegativeorZero();
                    }
                    else if (userResponse == "2")
                    {
                        // Call Problem 2 Method
                        LargestofThree();
                    }
                    else if (userResponse == "3")
                    {
                        // Call Problem 3 Method
                        CheckForAVowel();
                    }
                }
                // Loop Questions
                else if (userResponse == "2")
                { // created another set of menu questions for the rest of the methods
                    Console.WriteLine("4 - Multiplication Table ");
                    Console.WriteLine("5 - Check if a Number is Prime");
                    Console.WriteLine("6 - FizzBuzz");
                    userResponse = Console.ReadLine(); // reading response


                    if (userResponse == "4")
                    {
                        // Call Problem 4 Method
                        MultiplicationTable();
                    }
                    else if (userResponse == "5")
                    {
                        // Call Problem 5 Method
                        CheckIfANumberIsPrime();
                    }
                    else if (userResponse == "3")
                    {
                        // Call Problem 6 Method
                        FizzBuzz();
                    }

                }
                // Exit
                else if (userResponse == "3")
                {
                    Console.WriteLine("Exit");
                }
                else
                {
                    Console.WriteLine("Please enter a valid option");
                }

            } while (!isRunning);


        } // Menu decision structure




    } //class
} //namespace
