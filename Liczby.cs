using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LAB4
{
    public class Liczby
    {
        protected int a;
        protected int b;
        protected int c;

        public int get_a()
        {
            return this.a;
        }

        public int get_b()
        {
            return this.b;
        }

        public int get_c()
        {
            return this.c;
        }

        public void set_a(int a)
        {
            this.a = a;
        }

        public void set_b(int b)
        {
            this.b = b;
        }

        public void set_c(int c)
        {
            this.c = c;
        }

        public Liczby()
        {
            a = 0;
            b = 0;
            c = 0;
        }
    }
}