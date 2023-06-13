//DAY 1 BITCHES//

//Konversi();
//itungan();
//Modulus();
//OpPenugasan();
//OpPerbandingan();
//OpLogika();
//methodReturn();

Console.ReadKey();

static void methodReturn()
{
    Console.WriteLine("Method Return Type");
    Console.Write("Input Apel = ");
    int apel = int.Parse(Console.ReadLine());
    Console.Write("Input Mangga =  ");
    int mangga = int.Parse(Console.ReadLine());

    int jumlah = hasil(mangga, apel); //memanggil nilai perhitungan di bawah

    Console.WriteLine("Hasil Mangga + Apel = {0}", jumlah);
}
static int hasil (int mangga, int apel)
{
    int hasil = 0;
    hasil |= mangga + apel;
    return hasil;
}



static void OpLogika()
{
    Console.WriteLine("Operator Logika gerbang AND & OR");
    Console.WriteLine("Input Ur Age\t = ");
    int age = int.Parse(Console.ReadLine());
    Console.WriteLine("Input Passs\t = ");
    string pass = Console.ReadLine();

    bool isAdult = age > 18;
    bool isPass = pass == "Admin";
    
    if (isAdult && isPass)
    {
        Console.WriteLine("Welcome bitches");
     
    }
    else
    {
        Console.WriteLine("CABUT LU BOCIL" );
    }

}

static void OpPerbandingan()
{
    int mangga, apel = 0;

    Console.WriteLine("Perbandingan");
    Console.Write("Input Nilai Mangga\t = ");
    mangga = int.Parse(Console.ReadLine());
    Console.Write("Input Nilai Apel\t = ");
    apel = int.Parse(Console.ReadLine());
    Console.WriteLine("Hasil Perbandingan\t : ");
    Console.WriteLine($"Mangga > Apel\t: {mangga > apel}");
    Console.WriteLine($"Mangga < Apel\t: {mangga < apel}");
    Console.WriteLine($"Mangga >= Apel\t: {mangga >= apel}\t");
    Console.WriteLine($"Mangga <= Apel\t: {mangga <= apel}");
    Console.WriteLine($"Mangga == Apel\t: {mangga == apel}");
    Console.WriteLine($"Mangga != Apel\t: {mangga != apel}");
    
}
static void OpPenugasan()
{
    int mangga = 10, apel = 8;
    Console.WriteLine("Operator Penugasan");
    //isi ulang mangga
    mangga = 15;

    Console.Write("Input Mangga\t= "); //menggunakan inputan, variabel atas tidak digunakan, data lebih fleksibel
    mangga = int.Parse(Console.ReadLine()); 
    Console.WriteLine($"Mangga : {mangga}");

    apel += 6;
    Console.WriteLine($"Apel : {apel}");
}
static void Modulus()
{
    int mangga, orang, hasil = 0;

    Console.WriteLine("Hasil Modulus aka Hasil Bagi");
    Console.Write("Masukkan Mangga \t : ");
    mangga = int.Parse(Console.ReadLine()); //atau Convert.ToInt32(Console.ReadLine());
    Console.Write("Masukkan Jumlah Orang\t : ");
    orang = int.Parse(Console.ReadLine());

    hasil = mangga % orang;
    
    Console.WriteLine($"Hasil Mod = {hasil}");
}
static void itungan()
{
    int mangga, apel, hasil = 0;

    Console.WriteLine("Perhitungan");
    Console.Write("Masukkan Mangga : ");
    mangga = int.Parse(Console.ReadLine()); //atau Convert.ToInt32(Console.ReadLine());
    Console.Write("Masukkan Apel : ");
    apel = int.Parse(Console.ReadLine());

    hasil = mangga + apel;
    string nama = "Buku" + 10;
    Console.WriteLine($"Hasil = {hasil}");
    
}
static void Konversi ()
{
    Console.WriteLine("Mengkonversi Tipe Data");
    //convert tipe data
    int myInt = 10;
    double myDouble = 5.25;
    bool myBool = true;
       
   //opsi cara lain 
        /* string strMyInt = Convert.ToString(myInt);
        string strMyInt2 = myInt.ToString();
        Console.WriteLine(strMyInt);
        Console.WriteLine(strMyInt2); */
    
        Console.WriteLine(Convert.ToString(myInt));
        Console.WriteLine(Convert.ToDouble(myInt));
        Console.WriteLine(Convert.ToInt32(myDouble));
        Console.WriteLine(Convert.ToString(myBool));
 
}
