// See https://aka.ms/new-console-template for more information
using String_StringBuilder_Object_Class.Models;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;
using System.Xml;
using static System.Net.Mime.MediaTypeNames;
#region 1ci task
string words = "Salamnecesen";
//string[] result= words.Split(' ');
//for (int i = words.Length - 1; i >= 0; i--)
//{
//  //  Console.WriteLine(words[i]);
//    string JoinOne=String.Join(" ", words);
//    Console.WriteLine(JoinOne);
//}

string ReversedOne(string value)
{
    StringBuilder builder = new StringBuilder();
    for (int i = value.Length - 1; i >= 0; i--)
    {
        builder.Append(value[i]);
    }
    return builder.ToString();
}
Console.WriteLine(ReversedOne(words));
#endregion
#region 2ci task

Account account = new Account();
Console.WriteLine("enter your username:");
string EnteredUserName=Console.ReadLine();
Console.WriteLine("ENTER YOUR PASSSWORD:");
string EnteredPassword=Console.ReadLine();
account.Login(EnteredUserName,EnteredPassword);

#endregion
#region 3cu
Factorial factorial = new Factorial();
Console.WriteLine("reqemi daxil edin");
int exactValue=int.Parse(Console.ReadLine());
factorial.CalculationOfFactorial(exactValue);
#endregion
#region 4cu task
Calculator calculator = new Calculator();
Console.WriteLine("1ci reqemi daxil edin");
double number1=double.Parse(Console.ReadLine());
Console.WriteLine("2ci reqemi daxil edin");
double number2=double.Parse(Console.ReadLine());
char operators=char.Parse(Console.ReadLine());
calculator.CalculatorProgram(number1, number2, operators);

#endregion