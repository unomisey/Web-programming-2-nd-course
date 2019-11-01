using System;

namespace Formulas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 1-е число: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите 2-е число: ");
            int b = Convert.ToInt32(Console.ReadLine());
            KubRazn(x, b);
            KubSumm(x, b);
            SummaKubov(x, b);
            RaznostKubov(x, b);
        }
        
        static void KubRazn (int x, int b)
        {
            int rez = Pow(x, 3) - 3*Pow(x,2)*b + 3*x*Pow(b,2) - Pow(b,3);
            Console.WriteLine(rez);
        }
        
        static void KubSumm (int x, int b)
        {
            int rez = Pow(x, 3) + 3*Pow(x,2)*b + 3*x*Pow(b,2) + Pow(b,3);
            Console.WriteLine(rez);
        }

        static void SummaKubov(int x, int b)
        {
            int rez = (x + b)*(Pow(x, 2) - x * b + Pow(b, 2));
            Console.WriteLine(rez);
        }
        static void RaznostKubov(int x, int b)
        {
            int rez = (x - b)*(Pow(x, 2) + x * b + Pow(b, 2));
            Console.WriteLine(rez);
        }

        static int Pow(int a, int b)
        {
            for (int i = 0; i < b; i++)
            {
                a *= a;
            }
            return a;
        }
    }
    
    
}