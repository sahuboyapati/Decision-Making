using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConDecisionMaking
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.Write("Enter your exam score as a percentage: ");
                double score = Convert.ToDouble(Console.ReadLine());
                char grade;
                if (score >= 90)
                {
                    grade = 'A';
                }
                else if (score >= 80)
                {
                    grade = 'B';
                }
                else if (score >= 70)
                {
                    grade = 'C';
                }
                else if (score >= 60)
                {
                    grade = 'D';
                }
                else
                {
                    grade = 'F';
                }

                Console.WriteLine($"Your letter grade is: {grade}");
            Console.ReadKey();
            }
        }
    }