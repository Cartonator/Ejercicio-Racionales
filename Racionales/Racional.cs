using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racionales
{
    class Racional
    {
        private int a;
        private int b;
        public Racional(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public int getA()
        {
            return a;
        }

        public void setA(int a)
        {
            this.a = a;
        }

        public int getB()
        {
            return b;
        }

        public void setB(int b)
        {
            if (b == 0)
            {
                throw new Exception("forbbiden Value");
            }
            this.b = b;
        }
        public Racional Multiplicar(Racional p)
        {
            int a = this.a * p.getA();
            int b = this.b * p.getB();

            return new Racional(a, b);
        }
        public Racional Dividir(Racional p)
        {
            int a = this.a * p.getB();
            int b = this.b * p.getA();

            return new Racional(a, b);
        }

    }
}
