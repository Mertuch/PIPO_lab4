using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LAB4
{
    public class Lepsze_liczby : Liczby
    {
        protected int d;

        public Lepsze_liczby()
        {
            d = 0;
        }
        public void set_d(int d)
        {
            this.d = d;
        }
        public int get_d()
        {
            return this.d;
        }
    }



}