using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] marks = new int[6];
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Enter Marks in Subject"+(i+1));
                marks[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Student Marks as follows");
        
            for (int i = 0; i < 6;i++)
            {
                Console.WriteLine($"Subject {i+1} {marks[i]}");
            }
            Console.ReadKey();
        }
    }
}
