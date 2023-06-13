//Latihan DAY 2

//tes1();
//tes2();
//tes3();
//tes5();
//tes6();
//tes4();

Console.ReadKey();
static void tes1()
{
    // double phi = 3.142857142857143; 
    Console.WriteLine("Program Menghitung Luas dan Keliling sebuah lingkaran");
    Console.WriteLine("Input jari-jari\t : ");
    double r = Convert.ToDouble(Console.ReadLine());
    double L, K;

    K = 2 * Math.PI * r;
    L = Math.PI * r * r;

    Console.WriteLine($"Hasil Keliling {Math.Round(K)} cm2");
    Console.WriteLine($"Hasil Luas {Math.Round(L)} cm2");
}

static void tes2()
{
    
    Console.WriteLine("Program Menghitung Luas dan Keliling sebuah Persegi");
    Console.WriteLine("Input sisi\t : ");
    int s = int.Parse(Console.ReadLine());
    double L, K;

    K = 4 * s;
    L = s * s;

    Console.WriteLine($"Hasil Keliling \t = {K}");
    Console.WriteLine($"Hasil Luas \t = {L}");
}

static void tes3()
{
    int hasil = 0;
    Console.WriteLine("Program Menghitung Hasil Modulus");
    Console.Write("Input Angka\t : ");
    int angka = int.Parse(Console.ReadLine()); 
    Console.Write("Input Pembagi\t : ");
    int pembagi = int.Parse(Console.ReadLine());
    
    hasil = angka % pembagi;
    
    if (hasil == 0)
    {
        Console.WriteLine($"Angka {angka} % {pembagi} adalah {hasil}");
    }
    else
    {
        Console.WriteLine($"Angka {angka} % {pembagi} bukan 0 melainkan {hasil}");
    }

}

static void tes4()
{
    int puntungtukar;
    int rokok;
    int sisa;
    int penghasilan;

    Console.WriteLine("Banyak puntung rokok yg dikumpulkan : ");
    puntungtukar = int.Parse(Console.ReadLine());

    rokok = puntungtukar / 8;
    sisa = puntungtukar % 8;
    penghasilan = rokok * 500;

    Console.WriteLine($"Batang yang dapat dibuat {rokok}");
    Console.WriteLine($"Sisa Batang {sisa}");

    Console.WriteLine($"Penghasilan Yang Didapat : Rp.{penghasilan}");


}

static void tes5()
{
    Console.WriteLine("Program Menggrade Nilai");
    Console.WriteLine("Input nilai\t : ");
    int nilai = int.Parse(Console.ReadLine());
    if (nilai >= 80 && nilai <= 100)
    {
        Console.WriteLine("Grade Nilai Anda \t : A");
    }
    else if (nilai >= 60 && nilai < 80)
    {
        Console.WriteLine("Grade Nilai Anda \t : B");
    }
    else if (nilai < 60 && nilai >= 0 )
    {
        Console.WriteLine("Grade Nilai Anda \t : C");
    }
    
    else { Console.WriteLine("Nilai Tidak Terdefenisi"); }
}

static void tes6()
{
    Console.WriteLine("Program Ganjil Genap");
    Console.Write("Input nilai\t : ");
    int nilai = int.Parse(Console.ReadLine());

    if (nilai % 2 == 0)
    {
        Console.WriteLine($"Angka {nilai} Adalah Bilangan Genap");
    }
    else
    {
        Console.WriteLine($"Angka {nilai} Adalah Bilangan Ganjil");
    }
}