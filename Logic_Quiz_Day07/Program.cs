// DAY 7 QUIZ LOGIC //

soal1();
//soal2();
//soal3();
//soal4();
//test();
//tes2();

Console.ReadKey();

static void soal1()
{
    Console.WriteLine("--Program Perulangan 5 ");
    Console.Write("Inputkan Angka  : ");
    int a = int.Parse(Console.ReadLine());
    Console.Write("Bilangan Pengkali : ");   //dengan inputan awal
    int kali = int.Parse(Console.ReadLine());

    int x ;
    for (int i = 1; i <= a; i++)
    {
        //x = i * 5;
        x = i * kali; //dengan inputan

        if (i % 2 == 0)
        {
            Console.Write($"{-x} ");
        }
        else
        {
            Console.Write($"{x} ");
        }
    }
}

static void soal2()
{
    Console.WriteLine("--Program Convert 12 to 24 Hours--");
    Console.Write("Input Waktu Format 12 Hrs (01:00:00PM) : ");
    string time12 = Console.ReadLine();
        
    DateTime time = DateTime.ParseExact(time12, "hh:mm:sstt", null);
    string time24 = time.ToString("HH:mm:ss");

    Console.WriteLine($"Waktu 24 Jam : {time24}");

    Console.ReadLine();

}

static void soal3()
{
    string merk = null;
    int harga = 0;
    Console.WriteLine("--Program IMP Fashion--");
    try
    {
    a:
        Console.Write("Inputkan Kode Baju (1/2/3) : ");
        int code = int.Parse(Console.ReadLine());
        if (code > 3 || code <= 0)
        {
            Console.WriteLine("Kode Salah!!");
            Console.WriteLine("Inputkan ulang\n");

            goto a;
        }
        Console.Write("Inputkan Ukuran Baju : ");
        string size = Console.ReadLine().ToUpper();

        if (code == 1)
        {
            merk = "IMP";
            if (size == "s" || size == "S")
            {
                harga = 200000;
            }
            else if (size == "M" || size == "m")
            {
                size = "Rp. 220.000";
            }
            else
            {
                size = "Rp. 250.000";
            }
        }
        else if (code == 2)
        {
            merk = "Prada";
            if (size == "s" || size == "S")
            {
                size = "Rp. 150.000";
            }
            else if (size == "M" || size == "m")
            {
                size = "Rp. 160.000";
            }
            else
            {
                size = "Rp. 170.000";
            }
        }
        else if (code == 3)
        {
            merk = "Gucci";
            if (size == "s" || size == "S")
            {
                size = "Rp. 200.000";
            }
            else if (size == "M" || size == "m")
            {
                size = "Rp. 200.000";
            }
            else
            {
                size = "Rp. 200.000";
            }

        }
        Console.WriteLine($"Merk Baju : {merk} ");
        Console.WriteLine($"Ukuran =  {size}");
        Console.WriteLine($"Harga = Rp. {harga}");
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }

}

static void soal4()
{
    Console.WriteLine("--Program Menghitung Belanja Maks--");
    Console.Write("Input Uang : ");
    int uang = int.Parse(Console.ReadLine());

    Console.Write("Masukkan harga baju (pisahkan dengan koma): ");
    string[] inputHargaBaju = Console.ReadLine().Split(',');
    int[] hargaBaju = Array.ConvertAll(inputHargaBaju, int.Parse);

    Console.Write("Masukkan harga celana (pisahkan dengan koma): ");
    string[] inputHargaCelana = Console.ReadLine().Split(',');
    int[] hargaCelana = Array.ConvertAll(inputHargaCelana, int.Parse);

    int totalHargaMax = 0;

    for (int i = 0; i < hargaBaju.Length; i++)
    {
        for (int j = 0; j < hargaCelana.Length; j++)
        {
            int totalHarga = hargaBaju[i] + hargaCelana[j];
            if (totalHarga <= uang && totalHarga > totalHargaMax)
            {
                totalHargaMax = totalHarga;
            }
        }
    }

    Console.WriteLine("Total belanja maksimal: " + totalHargaMax);

}

static void soal5()
{
    

}

static void soal6()
{

}


static void test()
{
    //ini nomer 5//

    Console.WriteLine("Geser Geser Array");
    Console.Write("Masukkan Array Awal: ");
    string[] inputAwal = Console.ReadLine().Split(",");

    Console.Write("Masukkan Rotasi: ");
    int rotasi = int.Parse(Console.ReadLine());

    string[] Tampung = new string[1];

    for (int i = 0; i < rotasi; i++)
    {
        Tampung[0] = inputAwal[0];

        for (int j = 0; j < inputAwal.Length - 1; j++)
        {
            inputAwal[j] = inputAwal[j + 1];
        }

        inputAwal[inputAwal.Length - 1] = Tampung[0];

        Console.WriteLine($"{i + 1}: {string.Join(",", inputAwal)}");
    }
}
//{
//    Console.Write("Masukkan isi array (pisahkan dengan koma): ");
//    string[] inputArray = Console.ReadLine().Split(',');
//    int[] array = Array.ConvertAll(inputArray, int.Parse);

//    Console.Write("Masukkan jumlah rotasi: ");
//    int rotasi = int.Parse(Console.ReadLine());

//    Console.WriteLine("Array awal: " + string.Join(", ", array));

//    for (int i = 1; i <= rotasi; i++)
//    {
//        RotateArray(array);
//        Console.WriteLine("Rotasi " + i + ": " + string.Join(", ", array));
//    }
//}

//static void RotateArray(int[] array)
//{
//    int temp = array[0];
//    Array.Copy(array, 1, array, 0, array.Length - 1);
//    array[array.Length - 1] = temp;
//}



static void tes2()
{
    //ini nomor 6//

    Console.Write("Masukkan panjang array: ");
    int length = Convert.ToInt32(Console.ReadLine());

    int[] array = new int[length];
    Console.Write("Masukkan isi array (pisahkan dengan koma): ");
    string[] inputArray = Console.ReadLine().Split(',');

    for (int i = 0; i < length; i++)
    {
        array[i] = Convert.ToInt32(inputArray[i]);
    }

    Console.WriteLine("Array awal: " + string.Join(", ", array));

    BubbleSort(ref array);

    Console.WriteLine("Array setelah diurutkan: " + string.Join(", ", array));
}

static void BubbleSort(ref int[] array)
{
    int length = array.Length;

    for (int i = 0; i < length - 1; i++)
    {
        for (int j = 0; j < length - 1 - i; j++)
        {
            if (array[j] > array[j + 1])
            {
                int temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
            }
        }
    }
}