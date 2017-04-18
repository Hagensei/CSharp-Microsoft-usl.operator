using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Условный_оператор
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите своё имя:");
            var name = Console.ReadLine();
            if (name == "Вова")
            Console.WriteLine("Я так ждала тебя, " + name);
            else Console.WriteLine("Привет, {0}", name);
        }
    }
}
