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
            Console.WriteLine("Введите up/down: ");
            string sort = Convert.ToString(Console.ReadLine());
            Random rnd = new Random();

            int[] array = new int[len];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(min, max);
            }

            if (sort == "up")
                BubbleSortUp(array);
            else if(sort == "down")
                BubbleSortDown(array);
            
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                Console.Write(" ");
            }
        }
        
        static int[] BubbleSortUp(int[] s)
        {
            int c;
            for (int b = 0; b < s.Length; b++)
            {
                for (int i = 0; i < s.Length-1; i++)
                {
                    if (s[i] > s[i + 1])
                    {
                        c = s[i];
                        s[i] = s[i + 1];
                        s[i + 1] = c;
                    }
                }
            }
           
            return s;
        }
        static int[] BubbleSortDown(int[] s)
        {
            int c;
            for (int b = 0; b < s.Length; b++)
            {
                for (int i = 0; i < s.Length-1; i++)
                {
                    if (s[i] < s[i + 1])
                    {
                        c = s[i];
                        s[i] = s[i + 1];
                        s[i + 1] = c;
                    }
                }
            }
           
            return s;
        }
    }
}