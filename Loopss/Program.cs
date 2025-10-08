using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Loop4();
        }

        // Excerise -1 
        public static void Loop1()
        {
            Console.WriteLine("Exercise 1");
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Current line is: " + i);
                }
            }
        } 
        
        //  Excerise -2: Write a program that asks the user for a number N
        // and calculates the sum of the first N natural numbers using a for loop. 

        public static void Loop2()
        {
            int n = 5;
            int sum = 0;
            for (int i = 1; i <=n; i++)
            {
                sum = sum + i;
                
            }
            Console.WriteLine("Sum of first" + n + "natural no's is" + sum);
        }
        
        // Excerise -3: Write a program that prints the multiplication table of a number 
        //     entered by the user. Use a for loop to print 1 × N up to 10 × N.

        public static void Loop3()
        {
            int n = 10;
            int number = 7; 
            for (int i = 1; i <= n; i++)
            {
                int multiplication = number * i;
                Console.WriteLine( number +"x" +i+ "=" + multiplication);
                
            }
        }
        
        //Excerise -4 Write a program that reverses the digits of an integer using a for loop.
        public static void Loop4()
        {
            int num = 12345;
            string numstr = num.ToString();
            string reversedstr = "";

            for (int i = numstr.Length - 1; i >= 0; i--)
            {
                reversedstr = reversedstr + numstr[i];
            }
            Console.WriteLine("reversesd string is " + reversedstr);
            
        }
    }

};