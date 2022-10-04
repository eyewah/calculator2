using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string testResult = Calculator.ProcessStatement("1+1");
            Console.WriteLine("результат сложения   " + testResult);
            testResult = Calculator.ProcessStatement("2*3");
            Console.WriteLine("результат умножения   " + testResult);
            testResult = Calculator.ProcessStatement("3/3");
            Console.WriteLine("результат деления   " + testResult);
            testResult = Calculator.ProcessStatement("6-3");
            Console.WriteLine("результат вычитания   " + testResult);
            testResult = Calculator.ProcessStatement("6/0");
            Console.WriteLine("результат деления   " + testResult);



            Console.ReadKey();
            
        }
    }
}
