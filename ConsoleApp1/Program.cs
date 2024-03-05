using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[2, 3];
            int multiple;
            int sum;

            Random random = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(0, 10);
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

            multiple = array[0, 0] * array[1, 0];
            sum = array[1, 0] + array[1, 1] + array[1, 2];

            Console.WriteLine($"сумма второй строки:{sum}\n произведение первого столбца:{multiple}");
        }
    }
}
