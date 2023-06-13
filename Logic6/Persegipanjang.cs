using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic06
{
    public class Persegipanjang
    {
        public double panjang;
        public double lebar;
        public double Luaspersegipanjang()
        {
            return panjang*lebar;
        }
        public void tampilkanData()
        {
            Console.WriteLine($"Luas Perseagi Panjang : {Luaspersegipanjang()}");
        }
    }
}
