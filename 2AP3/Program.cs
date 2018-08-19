using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2AP3
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please Enter how many test scores you are going to enter");
            var numberOfTests = int.Parse(Console.ReadLine());
            int[] testScores = new int[numberOfTests];
            bool goodInput = true;
            string letterGrade;
            for (int i = 0; i < testScores.Length; i++)
            {
                do
                {
                    Console.WriteLine("Please enter a number between 1 and 100");
                    testScores[i] = int.Parse(Console.ReadLine());

                    if (testScores[i] < 0 || testScores[i] > 100)
                    {
                        goodInput = false;
                    }
                    else
                    {
                        goodInput = true;
                    }
                } while (!goodInput);
            }


            int sum = 0;

            for (int i = 0; i < testScores.Length; i++)
            {
                sum += testScores[i];
            }
            var average = sum / numberOfTests;
            if (average >= 94)
            {
                letterGrade = "A";
            }
            else if (average < 94 && average >= 90)
            {
                letterGrade = "A-";
            }
            else if (average < 90 && average >= 86)
            {
                letterGrade = "B+";
            }
            else if (average < 85 && average >= 83)
            {
                letterGrade = "B";
            }
            else if (average < 83 && average >= 80)
            {
                letterGrade = "B-";
            }
            else if (average < 80 && average >= 76)
            {
                letterGrade = "C+";
            }
            else if (average < 76 && average >= 73)
            {
                letterGrade = "C";
            }
            else if (average < 73 && average >= 70)
            {
                letterGrade = "C-";
            }
            else if (average < 70 && average >= 66)
            {
                letterGrade = "D+";
            }
            else if (average < 66 && average >= 63)
            {
                letterGrade = "D";
            }
            else if (average < 63 && average >= 60)
            {
                letterGrade = "D-";
            }
            else
            {
                letterGrade = "F";
            }

            Console.Write($"The average is {average} and the average letter grade is {letterGrade}");
            Console.Read();
        }
    }
}

