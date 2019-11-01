using System;

namespace ArrGen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину массива: ");
            int len = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите мин. элемент: ");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите макс. элемент: ");
            int max = Convert.ToInt32(Console.ReadLine());
            Random rnd = new Random();

            int[] array = new int[len];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(min, max);
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                Console.Write(" ");
            }
        }
    }
}
