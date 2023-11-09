using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppRectArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] myRArray = new string[4, 3]; 
            for (int i = 0; i < myRArray.GetLength(0); i++)
            {
                for (int j = 0; j < myRArray.GetLength(1); j++)
                {
                    myRArray[i, j] = "[ "+ i + ", " + j +"]";
                }
            }
            Console.WriteLine("Stored Values");
            for (int i = 0;i < myRArray.GetLength(0);i++)
            {
                for(int j = 0;j < myRArray.GetLength(1);j++)
                {
                    Console.Write(myRArray[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
