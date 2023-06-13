using Logic06;
// DAY 6 BITCHES //

//exabstractClass();
//exobjextclass();
//exconstructor();
//exEncaptulation();
//exInherritance();
//exoverridding();

Console.ReadKey();

static void exoverridding()
{
    Console.WriteLine("--Program Contoh Overriding--");
    kucing kucing = new kucing();
    paus paus = new paus();

    Console.WriteLine($"Kucing {kucing.pindah()} ");

    Console.WriteLine($"Paus {paus.pindah()}");
    //Console.Write("Paus "); paus.pindah();
}
static void exInherritance()
{
    Console.WriteLine("__Program Contoh Inheritance__");
    tipemobil tipe = new tipemobil();
    tipe.supra();
    
}
static void exEncaptulation()
{
    Console.WriteLine("--Program Contoh Encapsulasi--");
    Persegipanjang pp = new Persegipanjang();
    pp.panjang = 4.5;
    pp.lebar = 3.5;
    pp.tampilkanData();

}
static void exconstructor()
{
    Console.WriteLine("--Program Contoh Constructor--");
    Mobil mobil = new Mobil("BK 1448 QF");
    //string plat = mobil.plat;
    string plat = mobil.getplat(); //manggil dengan class
    Console.WriteLine($"NOPOL : {plat}");
}
static void exobjextclass()
{
    Console.WriteLine("--Program Tes Object Class--");
    Mobil mobil = new Mobil() { nama = "GTR E34", kecepatan = 0, bensin = 10, posisi = 0};
    mobil.plat = "DK 2795 XJ";
   

    mobil.percepat();
    mobil.maju();
    mobil.isibensin(20);
    mobil.utama();

}
static void exabstractClass()
{
    Console.WriteLine("--Program Tes Abstract Class--");
    Console.Write("Input Angka X = ");
    int x = int.Parse(Console.ReadLine());
    Console.Write("Input Angka Y = ");
    int y = int.Parse(Console.ReadLine());

    testturunann calc = new testturunann();
    int jumlah = calc.jumlah(x, y);
    int kurang = calc.kurang(x, y);

    Console.WriteLine($"Hasil Penjumlahan {x} + {y} : {jumlah} ");
    Console.WriteLine($"Hasil Pengurangan {x} + {y} : {kurang}");
}