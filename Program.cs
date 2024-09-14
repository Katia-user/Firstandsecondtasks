using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2

{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task 1
            string name = "Katia Rudyk";
            int age = 17;
            Console.WriteLine("task1");
            Console.WriteLine("Hello, {0},  i'm {1} years old!", name, age);

            //task 2
            int a = 3;
            int b = 6;
            double result;
            result = ((Math.Pow(a - b, 3) - Math.Pow(a, 3)) 
                / (Math.Pow(a, 3) - 3 * a * Math.Pow(b, 2) - 3 * Math.Pow(a, 2) * b)); Console.WriteLine("task2");
            Console.WriteLine($"result = {result}");
            Console.ReadKey();

            //task 3
            int input, output;
            Console.WriteLine("task3");
            Console.WriteLine("Enter a three-digit number");
            input = Convert.ToInt32(Console.ReadLine());
            output = (input % 10 * 100 + (input % 100 / 10 * 10) + (input / 100));
            Console.WriteLine($"{input} --> {output}"); Console.ReadKey();
        }
    }
}


