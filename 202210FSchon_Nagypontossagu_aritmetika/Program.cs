using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202210FSchon_Nagypontossagu_aritmetika
{
    class Program
    {
        struct Természetes
        {
            static readonly byte pontosság = 5;
           
            sbyte[] t; // számjelek tömbje
            byte h; // hossz;
            byte sz; // számrendszer


            // áttekinthető stringes konstruktor (ha még nehéz, ezt használd!)
            public Természetes(string szöveg)
            {
                this.t = new sbyte[pontosság];
                this.h = (byte)szöveg.Length;
                this.sz = 10;

                for (int i = szöveg.Length-1; 0 <= i; i--)
                {
                    t[szöveg.Length - 1 - i] = sbyte.Parse(szöveg[i].ToString());
                }
            }
            // elegáns
            // public Természetes(string szöveg) : this((byte)szöveg.Length, new sbyte[pontosság], 10) { }

            Természetes(byte h, sbyte[] t, byte sz) // alapkonstruktor
            {
                this.t = t;
                this.h = h;
                this.sz = sz;
            }
            public Természetes(int szám) : this(szám.ToString()) { }

            public override string ToString()
            {
                string sum = "";
                for (int i = pontosság-1; 0 <= i; i--)
                {
                    sum += t[i].ToString();
                }
                return sum;
            }
        }
        static void Main(string[] args)
        {
            //Természetes szám1 = new Természetes(5, new sbyte[] { 1, 5, 6, 4, 2 }, 10);
            Természetes szám3 = new Természetes("632");
            Természetes szám2 = new Természetes(65432);
//            Természetes szám4 = new Természetes("6A2",16);

  //          Console.WriteLine(szám4.ToInt32());
            Console.WriteLine(szám2);
            
            Console.ReadKey();
        }
    }
}
