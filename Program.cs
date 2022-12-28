using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace project__1program
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            {
                Console.WriteLine("Enter starting number:");
                int startNum = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter ending number :");
                int endNum = int.Parse(Console.ReadLine());
                Console.WriteLine("the prime number are  ");


                for (int i = startNum; i <= endNum; i++)
                {
                    int counter = 0;
                    for (int j = 2; j <= i / 2; j++)
                    {
                        if (i % j == 0)
                        {
                            counter++;
                            break;
                        }
                    }
                    if (counter == 0 && i != 1)
                    {
                        Console.WriteLine(i);
                    }
                }
            }


        }
   


} 
    }








