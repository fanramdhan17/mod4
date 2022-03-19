using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_1302204038
{
    public class Penjumlahan<T>
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
