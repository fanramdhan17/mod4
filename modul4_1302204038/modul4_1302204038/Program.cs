using System;
using System.Collections.Generic;

namespace modul4_1302204038
{
    class main
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Penjumlahan.JumlahTigaAngka<int>(12,34,56));
        }
    }
    class Penjumlahan
    {
        public static T JumlahTigaAngka<T>(T x, T y, T z)
        {
            dynamic a = x;
            dynamic b = y;
            dynamic c = z;

            return a + b + c;
        }
    }
}
