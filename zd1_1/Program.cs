using System;
using System.Linq;

namespace zd1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность массива");
            int n;
            if (Int32.TryParse(Console.ReadLine(), out n))
            {
                float[] mas = new float[n];
                for (int i = 0; i < n; i++)
                {
                    float.TryParse(Console.ReadLine(), out mas[i]);
                }
                Console.WriteLine(mas.Aggregate((x, y) => x - y));
            }
        }
    }
}
