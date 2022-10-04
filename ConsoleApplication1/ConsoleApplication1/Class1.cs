using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Calculator
    {
        public static string ProcessStatement(string statement)
        {
            string opearandA = statement.Substring(0, 1);
            string opearandB = statement.Substring(2, 1);
            string operation = statement.Substring(1, 1);
            int a = int.Parse(opearandA);
            int b = int.Parse(opearandB);
            string result = "";
            switch (operation)
            {
                case "+":
                    result = (a+b).ToString();
                    break;
                case "-":
                    result = (a-b).ToString();
                    break;
                case "/":
                    result = Divide(opearandA, opearandB);
                    break;
                case "*":
                    result = (a*b).ToString();
                    break;
                default:

                    break;
            }
            string resultString = result.ToString();
            return resultString;
        }

        public static string Divide(string a, string b)
        {
            string result = "";
            if (b == "0")
            {
                result = "На ноль делить нельзя";
            }
            else
            {
                int opearandA = int.Parse(a);
                int opearandB = int.Parse(b);
                result = (opearandA / opearandB).ToString();
            }
            return result;
        }
        
    }
}
