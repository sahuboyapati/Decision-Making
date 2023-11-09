﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstudMarks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* int[,] studMarks = new int[4, 4];

             // Input the roll numbers and marks for each student
             for (int i = 0; i < 4; i++)
             {
                 Console.Write("Enter Roll No for Student " + (i + 1) + ": ");
                 studMarks[i, 0] = int.Parse(Console.ReadLine());

                 Console.Write("Enter Semester 1 marks for Student " + (i + 1) + ": ");
                 studMarks[i, 1] = int.Parse(Console.ReadLine());

                 Console.Write("Enter Semester 2 marks for Student " + (i + 1) + ": ");
                 studMarks[i, 2] = int.Parse(Console.ReadLine());
             }

             Console.WriteLine("\nRollNo\tsem1\tsem2\tTotal");

             // Calculate the total marks and print the details
             for (int i = 0; i < 4; i++)
             {
                 int rollNo = studMarks[i, 0];
                 int sem1Marks = studMarks[i, 1];
                 int sem2Marks = studMarks[i, 2];
                 int totalMarks = sem1Marks + sem2Marks;

                 Console.WriteLine($"{rollNo}\t{sem1Marks}\t{sem2Marks}\t{totalMarks}");
             }

             Console.ReadLine(); // Wait for user to press Enter*/
            int[,] myRArray = new int[4, 4];
            for (int i = 0; i < 4; i++)
            {
                int total = 0;
                Console.WriteLine($"Enter Student {i + 1}\'s RollNumber");
                myRArray[i, 0] = int.Parse(Console.ReadLine());
                for (int j = 1; j < 3; j++)
                {
                    Console.WriteLine($"Enter Student {i + 1}\'s marks in sem {j}");
                    int marks = int.Parse(Console.ReadLine());
                    myRArray[i, j] = marks;
                    total += marks;
                }
                myRArray[i, 3] = total;
            }
            Console.WriteLine("Roll \t Sem1 \t Sem2 \t Total");
            for (int i = 0; i < myRArray.GetLength(0); i++)
            {
                for (int j = 0; j < myRArray.GetLength(1); j++)
                {
                    Console.Write(myRArray[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}




