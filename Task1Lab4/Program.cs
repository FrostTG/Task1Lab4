using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число");
            int N = Convert.ToInt32(Console.ReadLine());
            int N2 = 0;
            for (int i = 0; i < N; i++)
            {
                N2 += 2 * i + 1;
                Console.WriteLine("Квадрат числа {0} равен {1}", i + 1, N2); //Почему выводит только 298 значений квадрата?
            }
            Console.ReadKey();
        }
    }
}
