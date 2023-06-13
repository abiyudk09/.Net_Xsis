// Day 8 Quiz //

//no1();
//no6();
//no8();
//no3();
//no7();
//no4();
//tes();
//tes2();
//tesno5();
//no2();
//no10();
no9();

Console.ReadKey();

static void no1()
{
    Console.WriteLine("--Program Faktorial--");
    Console.WriteLine("Inputkan Angka : ");
    int angka = int.Parse(Console.ReadLine());
    int hasil = 1;
    string tampung = "";

        Console.Write($"!{angka} = ");
    for (int i = angka; i >= 1; i--)
    {
            hasil *= i;
        tampung += i == 1 ? i.ToString() : i.ToString() + " x "; // menggunakan ternary
        //if (i == 1 )
        //{
        //    Console.Write($"{i}");
        //}
        //else 
        //{ 
        //Console.Write($"{i}x");
        //}
    }
    Console.Write($" {tampung} = {hasil}");
    //Console.Write($" = {hasil}");
}

static void no6()
{
    Console.WriteLine("--Program Eja Input--");
    Console.Write("Inputkan Kata : ");
    string kata = Console.ReadLine().Replace(" ","").ToLower();
    Console.Write("Inputkan jumlah bintang : ");
    int star = int.Parse(Console.ReadLine());
    char[] katarr = kata.ToCharArray();

    for (int i = 0; i < kata.Length; i++)
    {
        for (int j = 0; j <= star * 2; j++)
        {
            if (j < star || j > star)
            {
                Console.Write("*");
            }
            else
            {
                Console.Write(katarr[i]);
            }


        }
        Console.WriteLine();
        //Console.WriteLine($"***{kata[i]}***"); //kalo make for
    }


    //INI YANG SIMPLE DENGAN BINTANG STATIS//
    //foreach(char word in katarr)
    //{
    //    Console.WriteLine($"***{word}***");
    //}
}

static void no8()
{
    Console.WriteLine("--Program StairCase--");
    Console.Write("Inputkan Angka : ");
    int input = int.Parse(Console.ReadLine());
    int x = input;
    for (int i = 1; i <= input; i++)
    {
        for (int j = 1; j <= input - i; j++)
        {
            Console.Write(" ");
        }
        for (int k = 1; k <= i; k++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }

    //option 2
    //for (int i = 0; i <= input; i++)
    //{
    //    for (int j = 0; j <= input; j++)
    //    {
    //        if (j <= input-i)
    //        {
    //            Console.Write(" ");
    //        }
    //        else
    //        {
    //        Console.Write("*");

    //        }
    //    }
    //    Console.WriteLine();
    //}

    //option 3
    //for (int i = 0; i < input; i++)
    //{

    //    for (int j = 0; j < input; j++)
    //    {
    //        if (j == input - 1)
    //        {
    //            Console.Write("#");
    //            x--;
    //        }
    //        else if (j >= x - 1)
    //        {
    //            Console.Write("#");
    //        }
    //        else
    //        {
    //            Console.Write(" ");

    //        }
    //    }
    //    Console.WriteLine();
    //}
}

static void no3()
{
    Console.WriteLine("--Program Pengembalian Buku--");
    Console.Write("Input Tanggal Peminjaman (31-01-2000) : ");
    string tglpinjam = Console.ReadLine();
    Console.Write("Input Tanggal Pengembalian (31-01-2000) : ");
    string tglbalik = Console.ReadLine();
    Console.Write("Input Batas Maksimal Pengembalian : ");
    int balik = int.Parse(Console.ReadLine());

    int d;

    DateTime tgl1 = DateTime.ParseExact(tglpinjam, "dd-MM-yyyy", null);
    DateTime tgl2 = DateTime.ParseExact(tglbalik, "dd-MM-yyyy", null);

    TimeSpan jarak = tgl2 - tgl1;

    d = (jarak.Days - balik) * 500;

    Console.WriteLine($"Jumlah Hari Keterlambatan :  {jarak.Days - balik}");
    Console.WriteLine($"Denda Yang Haarus Dibayarkan : Rp. {d}");
}

static void no7()
{
    Console.WriteLine("--Program Split Bill--");
    Console.Write("Inputkan Total Menu : ");
    int menu = int.Parse( Console.ReadLine() );
    Console.Write("Inputkan Index Menu Alergi : ");
    int alergi = int.Parse(Console.ReadLine());
    Console.Write("Inputkan Harga Menu : ");
    string[] listharga = Console.ReadLine().Split(" ");
    int[] harga = Array.ConvertAll(listharga, int.Parse);
   
    Console.Write("Inputkan Uang : ");
    int duid = int.Parse(Console.ReadLine());

    int sum = 0;
    int alergii = harga[alergi];
    int total = 0;
    int sisa = 0;

    foreach (int i in harga)
    {
        sum += i;
    }
    total = (sum - alergii)/2;
    sisa = duid - total;

    Console.WriteLine($"Jumlah yang harus dibayar = Rp. {total}");
    if (sisa > 0)
    {
    Console.WriteLine($"Sisa Uang = Rp. {sisa}");
    }
    else if (sisa < 0)
    {
        Console.WriteLine($"Uang kurang = Rp. {sisa}");
    }
    else
    {
        Console.WriteLine("Uang Pas");
    }

}

static void no2()
{
    Console.WriteLine("Masuka Kode SOS: ");
    string input = Console.ReadLine().ToUpper();
    int count = 0;
    int counts = 0;
    string sinyalValid = "";

    if (input.Length % 3 == 0)
    {
        for (int i = 0; i < input.Length; i += 3)
        {
            //if (input[i] != 'S')
            //    count++;
            //if (input[i + 1] != 'O')
            //    count++;
            //if (input[i + 2] != 'S')
            //    count++;
            if (input.Substring(i, 3) != "SOS")
            {
                sinyalValid += "SOS";
                count++;
            }
            else
            {
                sinyalValid += "SOS";
                counts++;
            }

        }

        Console.WriteLine("SOS yang Salah Sebanyak: " + count);
        Console.WriteLine("SOS yang benar Sebanyak: " + counts);
        Console.WriteLine("SOS Yang masook: " + input);
        Console.WriteLine("SOS yang Benar : " + sinyalValid);


    }
    else { Console.WriteLine($"Gagal, Code Kurang Digit"); }
}

static void no4()
{
    Console.WriteLine("--Cara Live Coding Pak Yahya--");
    Console.Write("Inputkan Tanggal Mulai (dd/MM/yyyy) : ");
    int[] arrTglMulai = Array.ConvertAll(Console.ReadLine().Split("/"), int.Parse);
    DateTime tglMulai = new DateTime(arrTglMulai[2], arrTglMulai[1], arrTglMulai[0]);
    Console.Write("Masukkan Lama Kelas (hari) : ");
    int durasi = int.Parse(Console.ReadLine());
    Console.Write("Inputkan Hari Libur (gunakan , sebagai pemisah) : ");
    int[] arrlibur = Array.ConvertAll(Console.ReadLine().Split(","), int.Parse);

    DateTime tglSelesai = tglMulai.AddDays(-1); //-1 karna tanggal mulai dihitung juga 1 hari

    for (int i = 0; i < durasi; i++)
    {
        for (int j = 0; j < arrlibur.Length; j++)
        {
            if (tglSelesai.Day == arrlibur[j])
            {
                tglSelesai = tglSelesai.AddDays(1);

                if (tglSelesai.DayOfWeek == DayOfWeek.Saturday)
                {
                    tglSelesai = tglSelesai.AddDays(2);
                }

            }
        }

        tglSelesai = tglSelesai.AddDays(1);

        if (tglSelesai.DayOfWeek == DayOfWeek.Saturday)
        {
            tglSelesai = tglSelesai.AddDays(2);
        }
    }

    DateTime tglUjian = tglSelesai.AddDays(1);

    if (tglUjian.DayOfWeek == DayOfWeek.Saturday)
    {
        tglUjian = tglUjian.AddDays(2);
    }
    Console.WriteLine($"Kelas akan ujian pada = {tglUjian.ToString("dd/MM/yyyy")}");

    // Cara Lain //
    //int durasi = 10;
    //Console.WriteLine("--Program Mulai Bootcamp--");
    //Console.Write("Input Tanggal Mulai (01/01/2000) : ");
    //string tglmulai = Console.ReadLine();
    //DateTime tgl1 = DateTime.ParseExact(tglmulai, "dd/MM/yyyy", null);

    //Console.Write("Hari Libur : ");
    //string libur = Console.ReadLine();
    //string[] dayoff = libur.Split(",");

    //DateTime tanggalujian = tgl1.AddDays(durasi);
    //foreach (string harilibur in dayoff)
    //{
    //    DateTime tanggalLibur = DateTime.ParseExact(harilibur.Trim(), "dd/MM/yyyy", null);

    //    if (tanggalLibur > tgl1 && tanggalLibur <= tanggalujian)
    //    {
    //        tanggalujian = tanggalujian.AddDays(1);
    //    }
    //}
    //while (tanggalujian.DayOfWeek == DayOfWeek.Saturday || tanggalujian.DayOfWeek == DayOfWeek.Sunday)
    //{
    //    tanggalujian = tanggalujian.AddDays(1);
    //}

    //Console.WriteLine($"Tanggal Ujian Akan dimulai pada {tanggalujian.ToString("dd/MM//yyyy")}");

}

static void tes()
{
    //initeh no 4

    Console.Write("Masukkan tanggal mulai (dd/MM/yyyy): ");
    string startDateString = Console.ReadLine();
    DateTime startDate = DateTime.ParseExact(startDateString, "dd/MM/yyyy", null);

    Console.Write("Masukkan jumlah hari: ");
    int duration = int.Parse(Console.ReadLine());

    Console.Write("Masukkan hari libur (pisahkan dengan koma): ");
    string holidayInput = Console.ReadLine();
    string[] holidayStrings = holidayInput.Split(',');
    int[] holidays = Array.ConvertAll(holidayStrings, int.Parse);

    DateTime examDate = CalculateExamDate(startDate, duration, holidays);

    Console.WriteLine("Ujian dilaksanakan: " + examDate.ToString("dd/MM/yyyy"));
}

static DateTime CalculateExamDate(DateTime startDate, int duration, int[] holidays)
{
    int count = 0;

    while (count < duration)
    {
        startDate = startDate.AddDays(1);

        if (startDate.DayOfWeek != DayOfWeek.Saturday && startDate.DayOfWeek != DayOfWeek.Sunday && !IsHoliday(startDate.Day, holidays))
        {
            count++;
        }
    }

    return startDate;
}

static bool IsHoliday(int day, int[] holidays)
{
    foreach (int holiday in holidays)
    {
        if (day == holiday)
        {
            return true;
        }
    }

    return false;


    //    Console.Write("Tanggal mulai (dd/MM/yyyy): ");
    //    string tanggalMulaiStr = Console.ReadLine();
    //    DateTime tanggalMulai = DateTime.ParseExact(tanggalMulaiStr, "dd/MM/yyyy", null);

    //    Console.Write("Hari Libur (dd/MM/yyyy, pisahkan dengan koma jika ada lebih dari satu): ");
    //    string hariLiburStr = Console.ReadLine();
    //    string[] hariLiburArray = hariLiburStr.Split(',');

    //    Console.Write("Lama kelas berlangsung (dalam jumlah hari): ");
    //    int lamaKelas = int.Parse(Console.ReadLine());

    //    DateTime tanggalUjian = HitungTanggalUjian(tanggalMulai, lamaKelas, hariLiburArray);
    //    Console.WriteLine("Tanggal kelas ujian: " + tanggalUjian.ToString("dd/MM/yyyy"));
    //}

    //static DateTime HitungTanggalUjian(DateTime tanggalMulai, int lamaKelas, string[] hariLiburArray)
    //{
    //    DateTime tanggalUjian = tanggalMulai;

    //    int hariDilaksanakan = 0;
    //    int totalHari = 0;

    //    while (hariDilaksanakan < lamaKelas)
    //    {
    //        tanggalUjian = tanggalUjian.AddDays(1);

    //        if (tanggalUjian.DayOfWeek == DayOfWeek.Saturday || tanggalUjian.DayOfWeek == DayOfWeek.Sunday)
    //            continue;

    //        totalHari++;

    //        bool adaLibur = false;
    //        foreach (string hariLibur in hariLiburArray)
    //        {
    //            DateTime tanggalLibur = DateTime.ParseExact(hariLibur.Trim(), "dd", null);

    //            if (tanggalUjian.Date == tanggalLibur.Date)
    //            {
    //                adaLibur = true;
    //                break;
    //            }
    //        }

    //        if (!adaLibur)
    //            hariDilaksanakan++;
    //    }

    //    return tanggalUjian;

    //    Console.Write("Tanggal mulai (dd/mm/yyyy): ");
    //    string tanggalMulaiStr = Console.ReadLine();
    //    DateTime tanggalMulai = DateTime.ParseExact(tanggalMulaiStr, "dd/MM/yyyy", null);

    //    Console.Write("Hari Libur (dd/mm/yyyy, pisahkan dengan koma jika ada lebih dari satu): ");
    //    string hariLiburStr = Console.ReadLine();
    //    string[] hariLiburArray = hariLiburStr.Split(',');

    //    int durasiKelas = 10;

    //    DateTime tanggalUjian = CalculateTanggalUjian(tanggalMulai, durasiKelas, hariLiburArray);
    //    Console.WriteLine("Kelas akan ujian pada: " + tanggalUjian.ToString("dd/MM/yyyy"));
    //}

    //static DateTime CalculateTanggalUjian(DateTime tanggalMulai, int durasiKelas, string[] hariLiburArray)
    //{
    //    DateTime tanggalUjian = tanggalMulai.AddDays(durasiKelas);

    //    foreach (string hariLibur in hariLiburArray)
    //    {
    //        DateTime tanggalLibur = DateTime.ParseExact(hariLibur.Trim(), "dd/MM/yyyy", null);

    //        if (tanggalLibur > tanggalMulai && tanggalLibur <= tanggalUjian)
    //        {
    //            tanggalUjian = tanggalUjian.AddDays(1);
    //        }
    //    }

    //    while (tanggalUjian.DayOfWeek == DayOfWeek.Saturday || tanggalUjian.DayOfWeek == DayOfWeek.Sunday)
    //    {
    //        tanggalUjian = tanggalUjian.AddDays(1);
    //    }

    //    return tanggalUjian;

}

static void tes2()
{
    //initeh no 2
    Console.Write("Masukkan sinyal yang diterima: ");
    string receivedSignal = Console.ReadLine();

    string correctSignal = GenerateCorrectSignal(receivedSignal.Length);
    int errorCount = 0;

    Console.WriteLine("Sinyal yang benar: " + correctSignal);
    Console.WriteLine("Sinyal yang diterima: " + receivedSignal);

    for (int i = 0; i < receivedSignal.Length; i++)
    {
        if (receivedSignal[i] != correctSignal[i])
        {
            errorCount++;
        }
    }

    Console.WriteLine("Total sinyal salah: " + errorCount);
}

static string GenerateCorrectSignal(int length)
{
    string correctSignal = "";

    while (length > 0)
    {
        correctSignal += "SOS";
        length -= 3;   
    }

    return correctSignal;

    //Console.Write("Masukkan sinyal yang diterima: ");
    //string receivedSignal = Console.ReadLine();

    //string correctSignal = "SOSSOSSOSSOS";
    //int errorCount = 0;

    //Console.WriteLine("Sinyal yang benar: " + correctSignal);
    //Console.WriteLine("Sinyal yang diterima: " + receivedSignal);

    //for (int i = 0; i < receivedSignal.Length; i++)
    //{
    //    if (receivedSignal[i] != correctSignal[i])
    //    {
    //        errorCount++;
    //    }
    //}

    //Console.WriteLine("Total sinyal salah: " + errorCount);
}

static void tesno5()
{
     Console.Write("Masukkan sebuah string: ");
    string input = Console.ReadLine();

    int jumlahvokal, jumlahkonsonan;
    hitunghuruf(input, out jumlahvokal, out jumlahkonsonan);

    Console.WriteLine("jumlah huruf vokal: " + jumlahvokal);
    Console.WriteLine("jumlah huruf konsonan: " + jumlahkonsonan);
}

static void hitunghuruf(string input, out int jumlahvokal, out int jumlahkonsonan)
{
    jumlahvokal = 0;
    jumlahkonsonan = 0;

    foreach (char huruf in input.ToLower())
    {
        if (char.IsLetter(huruf))
        {
            if (huruf == 'a' || huruf == 'e' || huruf == 'i' || huruf == 'o' || huruf == 'u')
                jumlahvokal++;
            else
                jumlahkonsonan++;
        }
    }
}

static void no5()
{
    
    Console.Write("Input kalimat : ");
    string kalimat = Console.ReadLine();

    int countVokal = 0;
    int countKonsonan = 0;

    string vokal = "aiueo";

    for (int i = 0; i < kalimat.Length; i++)
    {
        char huruf = char.ToLower(kalimat[i]);
        
        if (vokal.Contains(huruf))
        {
            countVokal++;
        }
        else if (char.IsLetter(huruf)) 
        {
            countKonsonan++;
        }
    }
    Console.WriteLine($"Huruf Vokal = {countVokal} ");
    Console.WriteLine($"Huruf Konsonan = {countKonsonan} ");
}

static void no9()

    {
        Console.WriteLine("--Soal Sembilan Cara 2--");
        int[,] angkaArr = {
        { 11, 2, 4 },       // (0,0) (0,1) (0,2)
        { 4, 5, 6 },        // (1,0) (1,1) (1,2)
        { 10, 8, -12 } };   // (2,0) (2,1) (2,2)

        int diagonalPertama = 0;
        int diagonalKedua = 0;
        string dayaTampungDP = "";
        string dayaTampungDK = "";
        for (int i = 0; i < angkaArr.GetLength(0); i++)
        {
            for (int j = 0; j < angkaArr.GetLength(1); j++)
            {
                if (i == j)
                {
                    diagonalPertama += angkaArr[i, j];
                //dayaTampungDP += String.Join("\t", angkaArr[i, j]);
                //switch (dayaTampungDP)
                //{
                //    case "":
                //        dayaTampungDP += angkaArr[i, j].ToString();
                //        break;
                //}
                //dayaTampungDP += dayaTampungDP == "" ? angkaArr[i, j].ToString() : angkaArr[i, j] < 0 ? " + " + $"({angkaArr[i, j].ToString()})" : " + " + angkaArr[i, j].ToString(); //$"({angkaArr[i, j].ToString()})"
                dayaTampungDP += dayaTampungDP == "" ? angkaArr[i, j].ToString() : angkaArr[i, j] < 0 ? " + " + $"({angkaArr[i, j].ToString()})" : " + " + angkaArr[i, j].ToString();

            }
                if (j == angkaArr.GetLength(1) - 1 - i)
                {
                    diagonalKedua += angkaArr[i, j];
                    dayaTampungDK += dayaTampungDK == "" ? angkaArr[i, j].ToString() : angkaArr[i, j] < 0 ? " + " + $"({angkaArr[i, j].ToString()})" : " + " + angkaArr[i, j].ToString();

                }
                Console.Write($"{angkaArr[i, j]}\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine("--------------------");
        int perbedaan = diagonalPertama - diagonalKedua;

        Console.WriteLine();
        Console.WriteLine("------------------------");
        Console.WriteLine($"Diagonal pertama: {dayaTampungDP} = {diagonalPertama}");
        Console.WriteLine($"Diagonal kedua: {dayaTampungDK} = {diagonalKedua}");
        Console.WriteLine("------------------------");
        Console.WriteLine($"Perbedaan |{diagonalPertama} - {diagonalKedua}| = {perbedaan}");
    Console.WriteLine($"/*Perbedaan |{diagonalPertama} - {diagonalKedua}| =*/ {Math.Abs(perbedaan)}");

}


static void no10()
{
    Console.WriteLine("masukin angka : ");
    string input = Console.ReadLine();
    string[] angka = input.Split(' ');

    int[] baru = new int[angka.Length];
    for (int i = 0; i < angka.Length; i++)
    {
        baru[i] = int.Parse(angka[i]);
    }

    int tertinggi = baru[0];
    int angkaTinggi = 0;

    for (int i = 0; i < baru.Length; i++)
    {
        if (baru[i] > tertinggi)
        {
            tertinggi = baru[i];
            angkaTinggi = 1;
        }
        else if (baru[i] == tertinggi)
        {
            angkaTinggi++;
        }
    }
    Console.WriteLine($"angka tertinggi : " + tertinggi);
    Console.WriteLine($"jumlah yg tertinggi : " + angkaTinggi);

}