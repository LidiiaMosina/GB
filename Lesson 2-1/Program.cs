using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите минимальную температуру ");
            double tmin = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите максимальную температуру ");
            double tmax = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Средняя температура {(tmin+tmax)/2}");
            Console.ReadLine();
        }
    }

}
