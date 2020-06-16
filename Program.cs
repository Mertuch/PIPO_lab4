using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Liczby L1  = new Liczby();
            Liczby L2  = new Liczby();
            Console.WriteLine("Stworzyłem L1 oraz L2:");
            Console.WriteLine(L1.get_a() + " " + L1.get_b() + " " + L1.get_c());
            Console.WriteLine(L2.get_a() + " " + L2.get_b() + " " + L2.get_c());
            Console.WriteLine("PRES ENY KII TU KONTINIU\n");
            Console.ReadKey();

            L1.set_a(2);
            L1.set_b(3);
            L1.set_c(4);

            L2.set_a(5);
            L2.set_b(6);
            L2.set_c(7);

            Console.WriteLine("Uzupełniłem L1 oraz L2:");
            Console.WriteLine(L1.get_a() + " " + L1.get_b() + " " + L1.get_c());
            Console.WriteLine(L2.get_a() + " " + L2.get_b() + " " + L2 .get_c());
            Console.WriteLine("PRES ENY KII TU KONTINIU\n");
            Console.ReadKey();

            Lepsze_liczby LL1 = new Lepsze_liczby();

            Console.WriteLine("STWORZYŁEM LL1:");
            Console.WriteLine(LL1.get_a() + " " + LL1.get_b() + " " + LL1.get_c() + " " + LL1.get_d());
            Console.WriteLine("PRES ENY KII TU KONTINIU\n");
            Console.ReadKey();




        }
    }
}
