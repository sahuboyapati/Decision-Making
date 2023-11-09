using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for(intialization;condition;changevalue)
            //{Body of loop;}

            //for(int i=1;i<=10;i++);
            //{
            //Console.WriteLine(i);
            //}
            // for (int i = 1; ; i++)
            // {
            //    Console.WriteLine(i);
            //}
            // Console.ReadKey();
            //while(condition);
            //Example_1
            /* int num = 10;
             Console.WriteLine("Start of While Loop");
             while(num <= 15)
             {
                 Console.WriteLine(num);
                 num++;
             }
             Console.WriteLine("End of While Loop");
             Console.WriteLine("----------------------------");

             int num2 = 10;
             Console.WriteLine("Start of Do While Loop");
             do
             {
                 Console.WriteLine(num2);
                 num2++;
             }
             while (num2 <= 15);
             Console.WriteLine("End od Do While Loop");
             Console.ReadKey();*/

            //Example_2
            /* int num = 20;
             Console.WriteLine("Start of While Loop");
             while (num <= 15)
             {
                 Console.WriteLine(num);
                 num++;
             }
             Console.WriteLine("End of While Loop");

             Console.WriteLine("----------------------------");

             int num2 = 20;
             Console.WriteLine("Start of Do While Loop");
             do
             {
                 Console.WriteLine(num2);
                 num2++;
             }
             while (num2 <= 15);
             Console.WriteLine("End of Do While Loop");
             Console.ReadKey();*/

            //Table Program
            /*int num;
            string choice;
            do
            {
                Console.WriteLine("Enter Number to find out Table");
                num = int.Parse(Console.ReadLine());
                Console.WriteLine("Table of " + num + "as follows");
                for (int i = 0; i <= 10; i++)
                {
                    Console.WriteLine($"{num} * {i} = {(num * i)}");
                }
                Console.WriteLine("Do you wanna continue? if yes press y \nTo Exit press Enter");
                choice = Console.ReadLine();

            }
            while (choice == "y");*/



            string cCode, lang, choice;
            do
            {
                Console.WriteLine("Enter Country Code");
                cCode = Console.ReadLine();
                switch (cCode)
                {
                    case "uk":
                    case "us":
                    case "ca":
                        {
                            lang = "English";
                            break;
                        }
                    case "ksa":
                    case "uae":
                    case "egypt":
                        {
                            lang = "Arabic";
                            break;
                        }
                    case "in":
                        {
                            lang = "Hindi,Urdu,Telugu,Tamil,Udai,Punjabi,Sindhi,English";
                            break;
                        }
                    case "af":
                        {
                            lang = "Dari,Persian,Pashto";
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Sorry But we dont find your country");
                            lang = "Not Found";
                            break;
                        }
                }
                Console.WriteLine($"Country code:\t{cCode}\n Language\\(s): \t {lang}");
                Console.WriteLine("Do you wanna continue? if yes press y \nTo Exit press Enter");
                choice = Console.ReadLine().ToLower();
            }
            while (choice == "y");
        }
    }
}
