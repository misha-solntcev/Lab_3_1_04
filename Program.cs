using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 4. Дано целое число N (> 0). Если оно является степенью числа 3, 
    то вывести True, если не является — вывести False.*/

namespace Lab_3_1_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = 9;
            Console.WriteLine(N % 3 == 0);
            Console.ReadKey();
        }
    }
}
