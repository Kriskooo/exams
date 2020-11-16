using System;
using System.Linq;

namespace ZigZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string[] array1 = new string[num];
            string[] array2 = new string[num];
            for (int i = 0; i < num; i++)
            {
                string[] currentNumber = Console.ReadLine().Split();
                if (i % 2 == 0)
                {
                    array1[i] = currentNumber[0];
                    array2[i] = currentNumber[1];
                }
                else
                {
                    array1[i] = currentNumber[1];
                    array2[i] = currentNumber[0];
                }

            }
            Console.WriteLine(string.Join(' ', array1));
            Console.WriteLine(string.Join(' ', array2));
        }
    }
}
