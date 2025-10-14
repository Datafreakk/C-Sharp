using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Loop6();
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
        
        public static void Loop5()
        {
            char[] arr  = { 'G', 'e', 'e', 'k' };
            foreach (char i in arr)
            {
                Console.WriteLine(i);
            }
        } 
        
        public static void Loop6()
        {
            string[] stringer = new[] { "Apple", "Bananad", "Camel" };
            foreach (string i in stringer)
            {
                Console.WriteLine(i);
            }

            List<int> Lister = new List<int> { 1, 2, 3 };
            
                foreach (int i in Lister)
                {
                    if (i != 0)
                    {
                        Console.WriteLine(i);   
                    }
                    else
                    {
                        Console.WriteLine("Cannot do operation");
                    }
                }

                Dictionary<string, int> dic = new Dictionary<string, int>
                {
                    { "A", 30 },
                    { "B", 25 },
                    { "C", 35 }
                };

                foreach (KeyValuePair<string, int> i in dic)
                {
                    Console.WriteLine($"{i.Key}:{i.Value}");
                }
                
                // Exercise 1: Count Vowels in a String
                // Exercise 2: Sum of All Even Numbers in a List

        }
    }

}