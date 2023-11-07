using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_StringBuilder_Object_Class.Models
{
    class Factorial
    {
 
        public void CalculationOfFactorial(int num)
        {

            if (num < 0)
            {
               
                Console.WriteLine("factorial ola bilmez");
            }
            else if (num == 0)
            {
             
                Console.WriteLine("1 e beraberdir");
            }
            else if (num >= 1)
            {
                int counter = 1;
                for (int i = 1; i <= num; i++) 
                {
                    counter *= i;
                }
               
               Console.WriteLine($"{num} bu ededin factoriali {counter}");
            }
        
        }

    }
}
