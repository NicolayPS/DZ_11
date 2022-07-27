using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Задача\nРазработать структуру для решения линейного уравнения 0=kx+b. \nКоэффициенты уравнения k, b реализовать с помощью полей вещественного типа. \nДля решения уравнения предусмотреть метод Root. \nСоздать экземпляр разработанной структуры. \nОсуществить использование экземпляра в программе.\n\nВведите количество попыток для этой программы:");
            int t = 0;
            try
            {
                t = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.Write("Ошибка! ");
                Console.WriteLine(ex.Message);
            }
            int o = 1;
            while (o <= t)
            {
                Console.WriteLine("Введите k");
                double k = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите b");
                double b = Convert.ToDouble(Console.ReadLine());

                make_yravnenie(k, b).check();
                make_yravnenie(k, b).Root();
                Console.WriteLine("Нажмите любую кнопку для продолжения!");
                Console.ReadKey();
                o++;
            }
        }
        static yravnenie make_yravnenie(double k, double b)
        {
            yravnenie yr1 = new yravnenie(k, b);
            return yr1;
        }
    }
}
