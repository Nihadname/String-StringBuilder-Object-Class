using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_StringBuilder_Object_Class.Models
{
     class Calculator
    {
        public void CalculatorProgram(double num1,double num2,char operators) {
            double counter = 0;
            switch (operators)
            {
                case '+':
                    counter=num1 + num2;
                    Console.WriteLine($"{counter}");
                    break;
                case '-':
                    counter=num1 - num2;
                    Console.WriteLine($"{counter}");
                    break;
                    case '*':
                    counter=num1 * num2;
                    Console.WriteLine($"{counter}");
                    break;
                case '/':
                    if (num2 == 0)
                    {
                        Console.WriteLine("0 a bolmek duzgun deyil");
                    }
                    else
                    {
                        counter = num2 / num1;
                        Console.WriteLine($"{counter}");
                    }
                    break;
                    default:
                    Console.WriteLine("operator sehv daxil olunmusdur");
                    break;


            }
        
        }
    }
}
