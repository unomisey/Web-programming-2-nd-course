using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            char sign;
            int num1;
            int num2;
            string exit = " ";

            while (exit != "exit")
            {
                Console.WriteLine("Введите знак:\n");
                sign = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("Введите первое число:\n");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите второе число:\n");
                num2 = Convert.ToInt32(Console.ReadLine());
                
                switch(sign)
                {
                    case '+':
                        Console.WriteLine(num1 + num2);
                        break;
                    case '-':
                        Console.WriteLine(num1 - num2);
                        break;
                    case '*':
                        Console.WriteLine(num1 * num2);
                        break;
                    case '/':
                        try
                        {
                            Console.WriteLine(Convert.ToDouble(num1) / num2);
                        }
                        catch (DivideByZeroException)
                        {
                            Console.WriteLine("DivideByZeroException");
                        }
                        break;   
                    default: 
                        Console.WriteLine("Неверный знак");
                        break;
                }
                Console.WriteLine("Введите exit для выхода или нажмите enter чтобы продолжить: \n");
                exit = Convert.ToString(Console.ReadLine());
            }
            Console.ReadKey();
        }
    }
}