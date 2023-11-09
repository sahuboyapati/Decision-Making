using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter Number of Students");
            num=int.Parse(Console.ReadLine());
            string[] students = new string[num];
            for(int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"Enter Student {i + 1}\'s name");
                 students[i] = Console.ReadLine();
            }
            Console.WriteLine("*** Student List as Follows ***");
            foreach(string student in students)
            {
                Console.WriteLine(student);
            }
            Console.ReadKey();
        }
    }
}
