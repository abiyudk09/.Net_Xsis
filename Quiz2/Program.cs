//Quiz Day 3//

//soal1();
//soal2();
//soal5();
//soal4();
soal8();
//soal7();
//soal3();
//Soal6();

Console.ReadKey();

static void soal1()
{
    Console.WriteLine("Program Grade Nilai");
    Console.Write("Inputkan Nilai = ");
    int nilai = int.Parse(Console.ReadLine());

   if (nilai >= 90 && nilai <= 100)
    {
        Console.WriteLine("Grade Nilai Anda \t : A");
    }
    else if (nilai >= 70 && nilai <= 89)
    {
        Console.WriteLine("Grade Nilai Anda \t : B");
    }
    else if (nilai >= 50 && nilai <= 69)
    {
        Console.WriteLine("Grade Nilai Anda \t : C");
    }
    else if (nilai < 50 && nilai >= 0)
    {
        Console.WriteLine("Grade Nilai Anda \t : E");
    }
    else { Console.WriteLine("Nilai Tidak Terdefenisi"); }
}

static void soal5()
{
    Console.WriteLine("Program Generasi");
    Console.Write("Input Nama Anda \t = ");
    string nama = Console.ReadLine();
    Console.Write("Inputkan Tahun Kelahiran Anda \t = ");
    int thn = int.Parse(Console.ReadLine());

    if (thn >= 1944 && thn <= 1964)
    {
        Console.WriteLine($"{nama}, berdasarkan tahun lahir anda tergolong Generasi Boomer ");
    }
    else if (thn >= 1965 && thn <= 1979)
    {
        Console.WriteLine($"{nama}, berdasarkan tahun lahir anda tergolong Gen X ");
    }
    else if (thn >= 1980 && thn <= 1994)
    {
        Console.WriteLine($"{nama}, berdasarkan tahun lahir anda tergolong Gen Y ");
    }
    else if (thn >= 1995 && thn <= 2015)
    {
        Console.WriteLine($"{nama}, berdasarkan tahun lahir anda tergolong Gen Z ");
    }
    else
    {
        Console.WriteLine("Generasi anda tidak terdefinisi");
    }
}

// Program no 2 dengan inputan nama jika kosong akan disuruh ulangi dan tahun jika tidak sesuai format akan di minta input ulang
//static void istilahLahir2()
//{
//    Console.WriteLine("Menentukan Istilah Kelahiran");
//    Console.WriteLine();
//    bool Ulangi = true;
//    string name = "";

//    while (Ulangi)
//    {
//        if (string.IsNullOrEmpty(name))
//        {
//            Console.Write("Masukkan nama anda : ");
//            name = Console.ReadLine();

//            if (string.IsNullOrEmpty(name))
//            {
//                Console.WriteLine("Nama tidak boleh kosong. Silakan coba lagi.");
//                continue;
//            }
//        }

//        int tahun;
//        Console.Write("Tahun berapa anda lahir : ");
//        string tahunInput = Console.ReadLine();

//        if (!int.TryParse(tahunInput, out tahun))
//        {
//            Console.WriteLine("Tahun lahir tidak boleh kosong dan harus berupa angka. Silakan coba lagi.");
//            continue;
//        }

//        if (tahun >= 1944 && tahun <= 1964)
//        {
//            Console.WriteLine($"{name}, berdasarkan tahun lahir anda tergolong 'Baby Boomer'");
//        }
//        else if (tahun >= 1965 && tahun <= 1979)
//        {
//            Console.WriteLine($"{name}, berdasarkan tahun lahir anda tergolong 'Generasi X'");
//        }
//        else if (tahun >= 1980 && tahun <= 1994)
//        {
//            Console.WriteLine($"{name}, berdasarkan tahun lahir anda tergolong 'Generasi Y(Millennials)'");
//        }
//        else if (tahun >= 1995 && tahun <= 2015)
//        {
//            Console.WriteLine($"{name}, berdasarkan tahun lahir anda tergolong 'Generasi Z'");
//        }
//        else if (tahun >= 2016 && tahun <= 2023)
//        {
//            Console.WriteLine($"{name}, berdasarkan tahun lahir anda tergolong 'Bau kencur'");
//        }
//        else if (tahun >= 2024)
//        {
//            Console.WriteLine($"{name}, berdasarkan tahun lahir anda tergolong 'Belum Lahir'");
//        }
//        else
//        {
//            Console.WriteLine($"{name}, berdasarkan tahun lahir anda tergolong 'Sudah Tua'");
//        }

//        Console.Write("Ulangi Proses (Y/N) : ");
//        string input = Console.ReadLine();

//        if (input.ToLower() == "n")
//        {
//            Ulangi = false;
//        }
//        else
//        {
//            name = string.Empty;
//        }
//    }
//}

static void soal2()
{
    Console.WriteLine("Program Grade Nilai");
    Console.Write("Inputkan Nominal Pulsa Anda = ");
    int pulsa = int.Parse(Console.ReadLine());

    if (pulsa >= 10000 && pulsa < 25000)
    {
        Console.WriteLine($"Pulsa \t : {pulsa}");
        Console.WriteLine("Point \t : 80");
    }
    else if (pulsa >= 25000 && pulsa < 50000)
    {
        Console.WriteLine($"Pulsa \t : {pulsa}");
        Console.WriteLine("Point \t : 200");
    }
    else if (pulsa >= 50000 && pulsa < 100000)
    {
        Console.WriteLine($"Pulsa \t : {pulsa}");
        Console.WriteLine("Point \t : 400");
    }
    else if (pulsa > 100000)
    {
        Console.WriteLine($"Pulsa \t : {pulsa}");
        Console.WriteLine("Point \t : 800");
    }
    else { Console.WriteLine("Beli Pulsa Lagi dan Dapatkan Poinnya"); }
}

static void soal3()

{ 
        double diskon, belanja, ongkir, total;
    
Console.WriteLine("Program Diskon OVO Grab");
Console.Write("Inputkan Total Belanja \t = ");
int shop = int.Parse(Console.ReadLine());
Console.Write("Inputkan Jarak \t = ");
int jarak = int.Parse(Console.ReadLine());
Console.Write("Kode Promo \t = ");
string promo = Console.ReadLine();

    ongkir = jarak * 1000;
    Console.WriteLine();
if (shop >= 30000 && shop <= 75000 && promo == "JKTOVO")
{
    diskon = shop * 0.4;
        belanja = shop - diskon;
    Console.WriteLine($"Belanja \t : {shop} ");
    Console.WriteLine($"Diskon 40% \t : {diskon} ");
    Console.WriteLine($"Ongkir \t \t : {ongkir} ");
        total = belanja + ongkir;
    Console.WriteLine($"Total Belanja \t : {total} ");
}
else if (shop > 75000 && promo == "JKTOVO")
    {
        Console.WriteLine($"Belanja \t : {shop} ");
        Console.WriteLine($"Diskon 40% \t : 30000 ");
        Console.WriteLine($"Ongkir \t \t : {ongkir} ");
        total = (shop - 30000) + ongkir;
        Console.Write($"Total Belanja \t : {total} ");
    }
else if (shop < 30000 && shop > 0 && promo == "JKTOVO")
    {
        Console.WriteLine($"Belanja \t : {shop} ");
        Console.WriteLine($"Diskon 40% \t : No Diskon ");
        Console.WriteLine($"Ongkir \t \t : {ongkir} ");
        total = shop + ongkir;
        Console.WriteLine($"Total Belanja \t : {total} ");
    }
else
    {
        Console.WriteLine("SHOPPING INVALID");
    }

}
static void soal4()
{
     bool ulangi = true; 
    int total;
    Console.WriteLine("Program Diskon Voucher Sopi");
    Console.WriteLine("Voucher Sopi :");
    Console.WriteLine("1. Min Order 30rb free ongkir 5rb dan potongan harga belanja 5rb");
    Console.WriteLine("2. Min Order 50rb free ongkir 10rb dan potongan harga belanja 10rb");
    Console.WriteLine("3. Min Order 100rb free ongkir 20rb dan potongan harga belanja 10rb \n");

    Console.Write("Inputkan Total Belanja \t = ");
    int shop = int.Parse(Console.ReadLine());
    Console.Write("Inputkan Ongkos Kirim \t = ");
    int ongkir = int.Parse(Console.ReadLine());
    Console.Write("Pilih Voucher \t = ");
    int promo =int.Parse(Console.ReadLine());

    //while (ulangi)
    //{ 

    if (shop >= 30000 && promo == 1)
    {
        total = shop + ongkir - 5000 - 5000;
        Console.WriteLine($"Belanja \t : {shop} ");
        Console.WriteLine($"Ongkos Kirim \t : {ongkir} ");
        Console.WriteLine("Diskon Ongkir \t : 5000 ");
        Console.WriteLine("Diskon Belanja \t : 5000 ");
        Console.WriteLine($"Total Belanja \t : {total} ");
    }
    else if (shop >= 50000 && promo == 2)
    {
        total = shop + ongkir - 10000 - 10000;
        Console.WriteLine($"Belanja \t : {shop} ");
        Console.WriteLine($"Ongkos Kirim \t : {ongkir} ");
        Console.WriteLine("Diskon Ongkir \t : 10000 ");
        Console.WriteLine("Diskon Belanja \t : 10000 ");
        Console.WriteLine($"Total Belanja \t : {total} ");
    }
    else if (shop >= 100000 && promo == 3)
    {
        total = shop + ongkir - 20000 - 10000;
        Console.WriteLine($"Belanja \t : {shop} ");
        Console.WriteLine($"Ongkos Kirim \t : {ongkir} ");
        Console.WriteLine("Diskon Ongkir \t : 20000 ");
        Console.WriteLine("Diskon Belanja \t : 10000 ");
        Console.WriteLine($"Total Belanja \t : {total} ");
    }
    else
    {
        Console.WriteLine("Tidak Dapat Menggunakan Voucher");
    }

    //    Console.Write("ulangi proses ? (y/n) : ");
    //    string input = Console.ReadLine();

    //    if (input.ToLower() == "y")
    //    {
    //        ulangi = true;
    //    }
    //    else if (input.ToLower() == "n")
    //    {
    //        ulangi = false;
    //    }
    //    else
    //    {
    //        Console.WriteLine("INVALID");
    //        ulangi = false;
    //    }
    //}
}

static void soal8()
{
    Console.WriteLine("Program KKM");
    Console.Write("Masukkan Nilai MTK \t : ");
    int mtk = int.Parse (Console.ReadLine());
    
    Console.Write("Masukkan Nilai Fisika \t : ");
    int fis = int.Parse(Console.ReadLine());
 
    Console.Write("Masukkan Nilai Kimia \t : ");
    int kim = int.Parse(Console.ReadLine());
    Console.WriteLine();

    float rata = (float)(mtk+fis+kim)/3;
    Console.WriteLine($"Nilai Rata-Rata \t : {rata}");

    if(rata >= 50 && rata <= 100)
    {
        Console.WriteLine("Selamaat");
        Console.WriteLine("Kamu Berhasil");
        Console.WriteLine("Kamu Hebat");
    }
    else if (rata < 50 && rata >= 0)
    {
        Console.WriteLine("Maaf");
        Console.WriteLine("Kamu Gagal :(");
    }
    else
    {

    }

}

static void soal7()
{
    Console.WriteLine("Program Body Mass Index");
    Console.Write("Masukkan Berat Badan Anda (kg) \t : ");
    float berat = float.Parse(Console.ReadLine());

    Console.Write("Masukkan Tinggi Badan Anda (cm) \t : ");
    float tinggi = float.Parse(Console.ReadLine());

    float bmi, height;
    height = (tinggi / 100) * (tinggi/100);

    bmi = berat / height;

    Console.WriteLine($"Nilai BMI anda adalah \t : {bmi}");
    
    if(bmi < 18.5)
    {
        Console.WriteLine("Anda Terlalu Kurus");
    }
    else if (bmi > 18.5 && bmi < 25)
    {
        Console.WriteLine("Anda termasuk berbadan Langsing");
    }
    else if (bmi >= 25)
    {
        Console.WriteLine("Anda Tergolong Gemuk");
    }
    else
    {

    }
}


//static void soal6()
//{
//at:
//    Console.WriteLine();
//    Console.WriteLine("Program GAJI PAJAK");
//    Console.Write("Nama \t : ");
//    string nama =   Console.ReadLine();
//    Console.Write("Tunjangan \t : ");
//    int tunj = int.Parse(Console.ReadLine());
//    Console.Write("Gapok \t : ");
//    int gap = int.Parse(Console.ReadLine());
//    Console.Write("Banyak Bulan \t : ");
//    int moon = int.Parse(Console.ReadLine());

//    int  galan, totga, gaji;
//    double pajak, bpjs, gbln, gtot;
//    gaji = tunj + gap;

//    if (gaji <= 5000000)
//    {
//        pajak = 0.05 * gaji;
//        bpjs = 0.03 * gaji;
//        gbln = (gap + tunj) - (pajak + bpjs);
//        gtot = gbln * moon;

//        Console.WriteLine($"Karyawan atas nama {nama} slip gaji sebagai berikut : ");
//        Console.WriteLine($"Pajak \t Rp. {pajak} ");
//        Console.WriteLine($"Bpjs \t Rp. {bpjs} ");
//        Console.WriteLine($"Gaji/Bulan \t Rp. {gbln} ");
//        Console.WriteLine($"Total Gaji \t Rp. {gtot} ");
//    }
//    else if (gaji > 5000000 && gaji <= 10000000)
//    {
//        pajak = 0.10 * gaji;
//        bpjs = 0.03 * gaji;
//        gbln = (gap + tunj) - (pajak + bpjs);
//        gtot = gbln * moon;

//        Console.WriteLine($"Karyawan atas nama {nama} slip gaji sebagai berikut : ");
//        Console.WriteLine($"Pajak \t Rp. {pajak} ");
//        Console.WriteLine($"Bpjs \t Rp. {bpjs} ");
//        Console.WriteLine($"Gaji/Bulan \t Rp. {gbln} ");
//        Console.WriteLine($"Total Gaji \t Rp. {gtot} ");
//    }
//    else if (gaji > 10000000)
//    {
//        pajak = 0.15 * gaji;
//        bpjs = 0.03 * gaji;
//        gbln = (gap + tunj) - (pajak + bpjs);
//        gtot = gbln * moon;

//        Console.WriteLine($"Karyawan atas nama {nama} slip gaji sebagai berikut : ");
//        Console.WriteLine("Pajak \t Rp.{0:#,0} ", pajak);
//        Console.WriteLine($"Bpjs \t Rp. {bpjs} ");
//        Console.WriteLine($"Gaji/Bulan \t Rp. {gbln} ");
//        Console.WriteLine($"Total Gaji \t Rp. {gtot} ");
//    }
//    else
//    {
//        Console.WriteLine("Invalid!!");
//    }
//    goto at;
//}

// lebih simple dan output lebih mudah dibaca, namun jika inputan salah seperti nama ada huruf atau kosong masih bisa lanjut 
static void Soal6()
{
    Console.Write("Nama: ");
    string nama = Console.ReadLine();

    Console.Write("Tunjangan: ");
    int tunjangan = Convert.ToInt32(Console.ReadLine());

    Console.Write("Gapok: ");
    int gapok = Convert.ToInt32(Console.ReadLine());

    Console.Write("Banyak Bulan: ");
    int banyakBulan = Convert.ToInt32(Console.ReadLine());

    double pajak, bpjs, gajiPerBulan, totalGaji;

    double totalPendapatan = gapok + tunjangan;

    if (totalPendapatan <= 5000000)
    {
        pajak = 0.05 * totalPendapatan;
    }
    else if (totalPendapatan <= 10000000)
    {
        pajak = 0.1 * totalPendapatan;
    }
    else
    {
        pajak = 0.15 * totalPendapatan;
    }

    bpjs = 0.03 * totalPendapatan;

    gajiPerBulan = totalPendapatan - (pajak + bpjs);
    totalGaji = gajiPerBulan * banyakBulan;

    Console.WriteLine("\nKaryawan atas nama {0} slip gaji sebagai berikut:", nama);
    Console.WriteLine("Pajak\t\tRp{0:#,0}", pajak);
    Console.WriteLine("BPJS\t\tRp{0:#,0}", bpjs);
    Console.WriteLine("Gaji/bulan\tRp{0:#,0}", gajiPerBulan);
    Console.WriteLine("Total gaji/{0} bulan\tRp{1:#,0}", banyakBulan, totalGaji);
}