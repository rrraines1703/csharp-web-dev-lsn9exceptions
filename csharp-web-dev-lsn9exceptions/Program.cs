using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;

namespace csharp_web_dev_lsn9exceptions
{
    class Program
    {
        static double Divide(double x, double y)
        {
            // Write your code here!
            if (y == 0)
            {
                throw new ArgumentOutOfRangeException("Error: Cannot divide by 0");
            } else
            {
                return x / y;
            }
        }

        static int CheckFileExtension(string fileName)
        {
            // Write your code here!
            int points = 0;

            if (String.IsNullOrEmpty(fileName))
            {
                throw new ArgumentNullException("Error: File Name");
            } else if (fileName.Substring(fileName.Length-3, 3) == ".cs")
            {
                points++;
            }
            return points;
        }


        static void Main(string[] args)
        {
            // Test out your Divide() function here!
            try
            {
                Console.WriteLine(Divide(47, 0));
            }
            catch (ArgumentOutOfRangeException outOfRange)
            {
                Console.WriteLine(outOfRange.Message);
            }

            try
            {
                Console.WriteLine(Divide(47, 1));
            }
            catch (ArgumentOutOfRangeException outOfRange)
            {
                Console.WriteLine(outOfRange.Message);
            }


            // Test out your CheckFileExtension() function here!
            Dictionary<string, string> students = new Dictionary<string, string>();
            students.Add("Carl", "Program.cs");
            students.Add("Brad", "");
            students.Add("Elizabeth", "MyCode.cs");
            students.Add("Stefanie", "CoolProgram.cs");


            foreach (KeyValuePair<string, string> student in students)
            {
                try
                {
                    Console.WriteLine($"{student.Key}: {CheckFileExtension(student.Value)}");
                }
                catch (ArgumentNullException nullException)
                {
                    Console.WriteLine(nullException.Message); 
                }
            }

        }
    }
}
