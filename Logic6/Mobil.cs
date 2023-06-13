using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic06
{
    public class Mobil
    {
        public double kecepatan;
        public double bensin;
        public double posisi;
        public string nama;
        public string plat;

        // consturctor
        public Mobil(string plat_no)  //constructor tuh abis public lgsg nama classnya gamake penjelas class lg
        {
            plat = plat_no;
        }

        //cons 2 tanpa parameter
        public Mobil()
        {

        }

        public string getplat() 
        {
            return plat;
        }


        public void percepat()
        {
            this.kecepatan += 10; 
            this.bensin -= 5;
        }
        public void maju()
        {
            this.posisi += this.kecepatan;
            this.bensin -= 2;
        }
        public void isibensin(double bensin)
        {
            this.bensin += bensin; // this itu gunanya untuk memanggil variabel dari class mobil, klo gapake this bisa sih cuman klo ada nama variabel yg sama dalam void lebih baik pake this
        }
        public void utama()
        {
            Console.WriteLine($"Car Name\t: {nama} ");
            Console.WriteLine($"Plate Number\t: {plat} ");
            Console.WriteLine($"Fuel\t\t: {bensin} ");
            Console.WriteLine($"Speed\t\t: {kecepatan} ");
            Console.WriteLine($"Position\t: {posisi} ");

        }
    }
}
