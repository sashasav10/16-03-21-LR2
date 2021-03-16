using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lr2_1
{
    class Program
    {
        delegate double Delegates(int x);
        static void Main(string[] args)
        {
            Console.WriteLine("Вводьте рядки послiдовно один за одним");
            Console.WriteLine("Поки вони не матимуть вигляд 0 х чи 1 х чи 2 х");
            Console.WriteLine("<тобто, цифра вiд 0 до 2, а пiсля неї запис конкретного дiйсного числа>, ");
            Console.WriteLine("програма обчислюватиме одну з трьох функцiй");
            Console.WriteLine("          0 -- sqrt(abs(x))");
            Console.WriteLine("          1 -- x^3 (syfrit rf;exb x*x*x)");
            Console.WriteLine("          2 -- x+3.5");
            Console.WriteLine("(згiдно цифри на початку) i виводитиме результват");
            Console.WriteLine("Якщо вхiдний рядок не задовольнятиме цей формат, програма завершить свою роботу");
            Delegates[] Methods = new Delegates[] { Method0, Method1, Method2 };
            while (true)
            {
                try
                {
                    int[] nums = Array.ConvertAll(Convert.ToString(Console.ReadLine()).Split(' '), int.Parse);
                    double output = Methods[nums[0]](nums[1]);
                    Console.WriteLine(output);
                }
                catch (Exception)
                {
                    Console.WriteLine("Сталася прикра помилка:(  Ви ввели непривальнi данi. Для остаточно виходу натiснiть щось");
                    break;
                }
            }
        Console.ReadKey();
        }
        static double Method0(int x)=>Math.Sqrt(Math.Abs(x));
        static double Method1(int x)=>x*x*x;
        static double Method2(int x)=>x + 3.5;
    }
}
