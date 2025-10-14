using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            RunStudentAnalyzer();

            //calling first foreach 
            // var nums = new List<int> { 2, 4, 1, 8, 16 };
            // var outlist = GetEvenSquaresAbove(nums, 4);
            // Console.WriteLine(string.Join(", ", outlist));

            //
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
            for (int i = 1; i <= n; i++)
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

        //Exercie-5
        public static List<int> GetEvenSquaresAbove(List<int> nums, int threshold)
        {
            var result = new List<int>();
            foreach (var i in nums)
            {
                if ((i % 2 == 0) && (i > 4))
                {
                    result.Add(i * i);
                }
            }

            return result;
        }
        
        //Excerise -6 : Foreach - Student Score Analyzer
        // you are given a list of students and their scores in different subjects.
        //     You must:
        //
        // Find the average score of each student.
        //
        //     Find the student(s) with the highest average.
        //
        //     Display all results neatly.

        public static void RunStudentAnalyzer()
        {
            List<Student> students = new List<Student>
            {
                new Student("praveen",new List<int>{10,20,40}),
                new Student("Lokesh",new List<int>{20,30,40}),
                new Student("siva", new List<int> {30,50,50})
    
            };

            var Studentavg = new Dictionary<String, double>();

            foreach (var i in students)
            {
                double total = 0;
                int count = 0;
                
                foreach (var j in i.Scores)
                {
                    total += j;
                    count += 1; //count ++
                    
                }
                double avg = total / count;
                Studentavg[i.Name] = avg;
                foreach (var kvp in Studentavg)
                {
                    Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
                }
                
            }

        }
    }

    
    class Student
    {
        public string Name { get; set; }
        public List<int> Scores { get; set; }

        public Student(string name, List<int> scores)
        {
            Name = name;
            Scores = scores;
        }

    }
    

};
    

