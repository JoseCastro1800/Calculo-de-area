using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoArea
{
    class Operacion
    {
        public double Multiplicar(double a, double b, double c = 2)
        {
            double t = (a * b) / c;
            return t;
        }

        public double Multiplicar(double a)
        {
            double c = a * a;
            return c;
        }

        public double Multiplicar (double a, double b)
        {
            double r = a * b;
            return r;

        }

        public double Multiplicar()
        {
            return 0;
        }
    }
}
