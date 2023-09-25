//=====================================================================
//
//Задача № 1 к семинару 1: Сравнение двух чисел
//
//=====================================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Начальный_проект
{
    public class Answer 
    {
        static void CompareNumbers(int firstNumber, int secondNumber)
        {
            if(firstNumber > secondNumber)
            {
                Console.Write("First number ");
                Console.Write(firstNumber);
                Console.Write(" is greater then second number ");
                Console.Write(secondNumber);
            }
            else if(firstNumber < secondNumber)
            {
                Console.Write("First number ");
                Console.Write(firstNumber);
                Console.Write(" is less then second number ");
                Console.Write(secondNumber);
            }
            else 
            {
                Console.Write("First number ");
                Console.Write(firstNumber);
                Console.Write(" is equal second number ");
                Console.Write(secondNumber);
            }
        }
    
        static public void Main(string[] args)//Для закпуска нажать Ctrl + F5
        {
            int firstNumber, secondNumber;
            if (args.Length >= 2)
            {
                firstNumber = int.Parse(args[0]);
                secondNumber = int.Parse(args[1]);
            }
            else
            {
                firstNumber = 5;
                secondNumber = 5;
            }
            CompareNumbers(firstNumber, secondNumber);
        }
    }
}
