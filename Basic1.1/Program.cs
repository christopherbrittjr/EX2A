using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Basic1._1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] testScores = new int[10];
            bool goodInput = true;
            for (int i = 0; i < 10; i++)
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
            int sum=0;

                for (int i = 0; i < 10; i++)
                {
                    sum += testScores[i];
                }

                Console.WriteLine($"The sum of the test scores is {sum}");
            }

        }
    }


