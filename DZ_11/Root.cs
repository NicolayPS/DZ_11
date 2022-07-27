using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_11
{
    class yravnenie

    {
        public double k;
        public double b;

        public yravnenie(double k, double b)
        {
            this.k = k;
            this.b = b;
        }
        public void check()
        {
            if ((this.k is double) && (this.b is double))
            {
                Console.WriteLine("проверка пройдена");
            }
            else
            {
                Console.WriteLine("проверка не пройдена");
            }

        }
        public void Root()
        {
            double x = 0;
            if (this.k != 0)
            {
                x = (-this.b / this.k);
                Console.WriteLine("x={0}", x);
            }
            else
            {
                if (this.b == 0)
                {
                    Console.WriteLine("x - любое число");
                }
                else
                {
                    Console.WriteLine("уравнение не имеет решения");
                }
            }
        }
    }
}
