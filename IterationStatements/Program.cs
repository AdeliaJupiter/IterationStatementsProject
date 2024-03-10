﻿using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //---------------------------EXERCISE 1-----------------------------
            Console.WriteLine($"-------EXERCISE 1------");
            for(int i = 0; i < 5; i++) //1
            {
                Console.WriteLine($"{i}");
            }
            for (int i = 0; i < 5; i++) //2
            {
                Console.WriteLine($"{i}");
            }
            for (int i = 0; i < 5; i++) //3
            {
                Console.WriteLine($"{i}");
            }
            for (int i = 0; i < 5; i++) //4
            {
                Console.WriteLine($"{i}");
            }
            for (int i = 0; i < 5; i++) //5
            {
                Console.WriteLine($"{i}");
            }
            for (int i = 0; i < 5; i++) //6
            {
                Console.WriteLine($"{i}");
            }
            for (int i = 0; i < 5; i++) //7
            {
                Console.WriteLine($"{i}");
            }
            for (int i = 0; i < 5; i++) //8
            {
                Console.WriteLine($"{i}");
            }
            for (int i =0; i < 5; i++) //9
            {
                Console.WriteLine($"{i}");
            }
            for (int i=0; i < 5; i++) //10
            {
                Console.WriteLine($"{i}");
            }
            for (int i = 0; i < 5; i++) //11
            {
                Console.WriteLine($"{i}");
            }
            for (int i = 0 ; i < 5 ; i++) //12
            {
                Console.WriteLine($"{i}");
            }
            for (int i = 0; i < 5 ; i++) //13
            {
                Console.WriteLine($"{i}");
            }
            for (int i = 0; i < 5 ; i++) //14
            {
                Console.WriteLine($"{i}");
            }
            for (int i = 0; i < 5; i++) //15
            {
                Console.WriteLine($"{i}");
            }
            Console.WriteLine();


            //---------------------------EXERCISE 2-----------------------------
            //TODO - Read each comment and complete its instruction
            // like the example below
            Console.WriteLine($"-------EXERCISE 2-------");

            //Create a List called "numbers" - DONE!
            var numbers = new List<int>();

            //-----START HERE------------------------------------------
            //Create a variable of type int and name it num
            //initialize the variable with a value of 0
            int num = 0;


            // Create a do-while loop and use the template below:

            do
            {
                // Increment num by 1
                num++;
                // Then add num to the collection - numbers
                // Hint: reference num inside of the Add method's parentheses
                numbers.Add(num);

            } while (num < 100); // <---- While your variable is less than 100



            // Create a while loop
            while (num < 200) // <--- While num is less than 200
            {
                num++;// Increment num by 1
                // Then add num to the collection numbers
                numbers.Add(num);    //HINT: copy how this was done in the do while loop

            }


            // This is to show the user that the numbers will start increasing on the console
            Console.WriteLine("Increase:");


            // Create a foreach loop using the collection - numbers
                //In the scope of the foreach loop, print each number in numbers

            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
             


            Console.WriteLine("");
            Console.WriteLine("Decrease:");


            // Create a for loop - this will print the numbers in reverse order - from 200 to 1
                // in your initializer set the value of i to 199
                // in your conditional, as long as i is less than or equal to the amount of items in "numbers" - use (numbers.Count)
                // AND as long as i is greater than or equal to 0
                // Decrement i by 1

            //start for loop here
            for (int i = 199; i >= 0 && i <= numbers.Count; i--)
            {
                Console.WriteLine(numbers[i]);// place numbers[i] inside of the Console.WriteLine() method
            }
            Console.WriteLine();
            //------------End of exercise

            //----------------------EXERCISE 3----------------------
            Console.WriteLine($"--------EXERCISE 3--------");

            ThousandNegThousand();
            UpByThree();

            Console.WriteLine($"Enter two numbers");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            bool isEqual = IsEqual(x, y);
            if(isEqual == true) 
            { 
                Console.WriteLine("Equal!"); 
            }
            else
            {
                Console.WriteLine("Not equal :(");
            }
        }

        //METHODS
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void ThousandNegThousand()
        {
            Console.WriteLine($"**1000 to -1000**");
            var num = 1000;
            do
            {
                Console.WriteLine(num);
                num--;
            } while (num >= -1000);
            Console.WriteLine();
        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void UpByThree()
        {
            Console.WriteLine($"**3 to 999 by 3**");
            var num = 3;
            do
            {
                Console.WriteLine(num);
                num = num + 3;
            } while (num < 1000);
            Console.WriteLine() ;
        }

        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static bool IsEqual(int  x, int y)
        {
            bool isEqual;

            if (x == y)
            {
                isEqual = true;
            }
            else
            {
                isEqual = false;
            }

            return isEqual;
        }

        //Write a method to check whether a given number is even or odd

        //Write a method to check whether a given number is positive or negative

        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10

        //Write a method to display the multiplication table(from 1 to 12) of a given integer


        //Call the methods to test them in the Main method below
    }
}
