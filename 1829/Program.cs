using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1829
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int exit = -1;
            Console.WriteLine("Введите число A:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число B:");
            int b = Convert.ToInt32(Console.ReadLine());
            while (exit != 0)
            {
                Console.WriteLine("1 + ) 2 - ) 3 * ) 4 / )");
                exit = Convert.ToInt32(Console.ReadLine());
                switch (exit)
                {
                    case 0:
                        Console.WriteLine("Программа завершена.");
                        break;
                    case 3:
                        {
                            int result = a * b;
                            Console.WriteLine("Результат: " + result);
                            break;
                        }
                    default:
                        Console.WriteLine("Введите верный элемент меню");
                        break;
                }
            }
        }
    }
}