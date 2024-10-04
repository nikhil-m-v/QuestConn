using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopQns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int sum = 0;
            //for (int i = 1; i <= 5; i++) { 
            //    sum = sum + i;

            //}
            //Console.WriteLine(sum);
            //Console.ReadLine();
            int number = 1; 
            int rows = 4;    

            for (int i = 1; i <= rows; i++) 
            {
                
                for (int j = 1; j <= rows - i; j++)
                {
                    Console.Write(" ");
                }

                
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(number + " ");
                    number++;
                }

                
                Console.WriteLine();
                Console.Write(" ");
            }
            Console.ReadLine();
            }
    }
}
