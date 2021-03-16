using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lr2Task2
{
    class Program
    {
        delegate void Deledate(int sec);

        public delegate void Metody();
        static void Main(string[] args)
        {
            Console.Write("Введiть кiлькiсть секунд: ");
            int sec = int.Parse(Console.ReadLine());
            Timer timer = new Timer();
            Deledate del = timer.Start;
            del.Invoke(sec);
        }
    }
}
