using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2AP4
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter as many test scores that you would like to average with a grade. ");
            Console.WriteLine("To stop, please press q and press enter.");
            Console.WriteLine();

            List<int> testScores = new List<int>();
            int testScoreInput;
            bool badInput = false;
            string letterGrade;
            string input;
            bool end = false;
            

            do
            {

                badInput = false;
                Console.WriteLine("Please enter a test score: ");
                input = Console.ReadLine();
                if (input.ToLower() == ("q"))
                {
                    end = true;
                    break;
                }
                testScoreInput = int.Parse(input);
                if (testScoreInput < 0 || testScoreInput > 100)
                {
                    badInput = true;
                }
                else
                {
                    testScores.Add(int.Parse(input));
                    end = false;
                    badInput = false;
                }
            } while (badInput || !end);



                int sum = 0;

                for (int i = 0; i < testScores.Count; i++)
                {
                    sum += testScores[i];
                }
                var average = sum / testScores.Count;
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
                

