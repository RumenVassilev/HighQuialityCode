using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02OperationsTest
{
    class IntTesting
    {
        public static void Main()
        {
            // Int Testing

            // Add
            Console.WriteLine("Add int:");
            DisplayExecutionTime(() =>
            {  
                List<int> list1 = new List<int>();
                list1.Add(1);
            });

            // Substract
            Console.WriteLine("Substract:");
            DisplayExecutionTime(() =>
            {  
                DateTime christmas = new DateTime(2008, 12, 25);
                DateTime newYears = new DateTime(2009, 1, 1);
                TimeSpan span = newYears.Subtract(christmas);
            });

            // Increment
            Console.WriteLine("Increment int:");
             DisplayExecutionTime(() =>
            { 
                int example = 2;
                example++;
                example += 10;
                ++example;
                example += example;
            });

            // Multiply
            Console.WriteLine("Multiply int:");
            DisplayExecutionTime(() =>
            {
                int operator1 = 10;
                int operator2 = 5;
                int sum = operator1 * operator2;
            });

            // Devide
            Console.WriteLine("Devide int:");
            DisplayExecutionTime(() =>
            {
                int operator1 = 10;
                int operator2 = 5;
                int devided = operator1 / operator2;
            });

            // Double Testing

            // Add
            Console.WriteLine("Add double:");
            DisplayExecutionTime(() =>
            {
                List<double> list1 = new List<double>();
                list1.Add(1);
            });

            // Substract
            Console.WriteLine("Substract Date:");
            DisplayExecutionTime(() =>
            {
                DateTime christmas = new DateTime(2008, 12, 25);
                DateTime newYears = new DateTime(2009, 1, 1);
                TimeSpan span = newYears.Subtract(christmas);
            });

            // Increment
            Console.WriteLine("Increment double:");
            DisplayExecutionTime(() =>
            {
                double example = 2;
                example++;
                example += 10;
                ++example;
                example += example;
            });

            // Multiply
            Console.WriteLine("Multiply double:");
            DisplayExecutionTime(() =>
            {
                double operator1 = 10;
                double operator2 = 5;
                double sum = operator1 * operator2;
            });

            // Devide
            Console.WriteLine("Devide double:");
            DisplayExecutionTime(() =>
            {
                double operator1 = 10;
                double operator2 = 5;
                double devided = operator1 / operator2;
            });
            // I'm sorry for not putting the code in different classes and not doing it for decimal i long but I have no time for finishing
            // the task. Wish you like the code i wrote :)
        }
        static void DisplayExecutionTime(Action action)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            action();
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
        }
    }
}
