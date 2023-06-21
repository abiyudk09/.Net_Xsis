// Quiz DAY 4

//soal1();
soal2();
//soal3();
//soal4();
//soal5();
//soal6();
//soal7();
//soal8();


Console.ReadKey();

static void soal1()
{

a:
    int upah = 0;
    double lembur = 0, total = 0;

    Console.WriteLine("--Program Gaji Swasta--");
    try
    {

        d:
        Console.Write("Masukkan Golongan anda (1/2/3/4) : ");
        int gol = int.Parse(Console.ReadLine());
      
        if (gol > 4)
        {
            Console.WriteLine("!!GOLONGAN TIDAK TERSEDIA!! \n");
            Console.WriteLine("Mohon Input Golongan Yang Benar : ");
            goto d;
        }
       

    c:
        try
        {
            Console.WriteLine();
                Console.Write("Masukkan Jam Kerja anda : ");
            int jam = int.Parse(Console.ReadLine());
           
            if (jam <= 40 && jam > 0)
            {
             

                switch (gol)
                {
                    case 1:
                        {
                            upah = 2000 * jam;
                            total = upah;
                        }
                        break;
                    case 2:
                        {
                            upah = 3000 * jam;
                            total = upah ;
                        }
                        break;
                    case 3:
                        {
                            upah = 4000 * jam;
                            total = upah;
                        }
                        break;
                    case 4:
                        {
                            upah = 5000 * jam;
                            total = upah ;
                        }
                        break;
                }
 

            }
            else if (jam > 40)
            {
           
                switch (gol)
                {
                    case 1:
                        {
                            upah = 2000 * 40;
                            lembur = (1.5 * 2000) * (jam - 40);
                            total = upah + lembur;
                        }
                        break;
                    case 2:
                        {
                            upah = 3000 * 40;
                            lembur = (1.5 * 3000) * (jam - 40);
                            total = upah + lembur;
                        }
                        break;
                    case 3:
                        {
                            upah = 4000 * 40;
                            lembur = (1.5 * 4000) * (jam - 40);
                            total = upah + lembur;
                        }
                        break;
                    case 4:
                        {
                            upah = 5000 * 40;
                            lembur = (1.5 * 5000) * (jam - 40);
                            total = upah + lembur;
                        }
                        break;
                }

            }
            else
            {
                Console.WriteLine("INVALID");
            }

        }
        catch (Exception e)
        {

            Console.WriteLine("!!Must Number and Not Empty!!");
            goto c;

        }
        Console.WriteLine($"Upah \t Rp.{upah}");
        Console.WriteLine($"Lembur \t Rp.{lembur}");
        Console.WriteLine($"Total \t Rp.{total}");
    }
    catch (Exception e)
    {

        Console.WriteLine("!!Must Number and Not Empty!!");
    }
b:
    Console.WriteLine("");
    Console.Write("Coba Lagi ? (y/n) : ");
    string yn = Console.ReadLine();
    if (yn == "y")
    {
        goto a;
    }
    else if (yn == "n")
    {
        Console.WriteLine("Press Any Button to Exit!");
    }
    else
    {
        Console.WriteLine("INPUT YANG BENER, UDAH ADA ITU PILIHANNYA!!!");
        goto b;
    }
}

static void soal2()
{
    Console.WriteLine("Program Split");
    Console.Write("Input Kalimat = ");
    string word = Console.ReadLine();

    string[] kalimat = word.Split(' ');


    for (int i = 0; i < kalimat.Length; i++ )
    {
        Console.WriteLine($"Kata {i+1} : {kalimat[i]}");
    }

    //foreach (var kata in kalimat)
    //{
    //    Console.WriteLine(kata);
    //}

    Console.WriteLine($"Total Kata = {kalimat.Length}\n");


}


static void soal3()
{
    Console.WriteLine("Program Mengganti Kata Tengah");
    Console.Write("Input Kalimat : ");
    string kalimat = Console.ReadLine();

    string[] kata = kalimat.Split(' ');
    string hasil = "";

    for (int i = 0; i < kata.Length; i++)
    {
        string kataBaru = "";

        for (int j = 0; j < kata[i].Length; j++)
        {
            if (j == 0 || j == kata[i].Length - 1)
            {
                kataBaru += kata[i][j];
            }
            else
            {
                kataBaru += "*";
            }
        }

        hasil += kataBaru + " ";
    }
    Console.WriteLine("hasil : " + hasil);

}
//static string GantiKata(string kalimat)
//{
//    string[] kata = kalimat.Split(' ');
//    string hasil = "";

//    for (int i = 0; i < kata.Length; i++)
//    {
//        string kataBaru = "";

//        for (int j = 0; j < kata[i].Length; j++)
//        {
//            if (j == 0 || j == kata[i].Length - 1)
//            {
//                kataBaru +=  kata[i][j];
//            }
//            else
//            {
//                kataBaru += "*";
//            }
//        }
//        hasil += kataBaru + " ";
//    }
//    return hasil.Trim();

//}


static void soal4()
{
    Console.WriteLine("Program Mengganti Awalan dan Akhiran");
    Console.Write("Masukkan kalimat: ");
    string word = Console.ReadLine();

    string[] katapecah = word.Split(' ');
    string hasil = "";

        for (int i = 0; i < katapecah.Length; i++)
        {
            string kataBaru = "";

            for (int j = 0; j < katapecah[i].Length; j++)
            {
                if (j == 0 || j == katapecah[i].Length - 1)
                {
                    kataBaru += "*";
                }
                else
                {
                    kataBaru += katapecah[i][j];
                }
            }
            hasil += kataBaru + " ";
        }

        //for (int i = 0; i < kata.Length; i++)
        //{
        //    string kataBaru = "";
        //    if (kata[i].Length > 1)
        //    {
        //        char[] karakter = kata[i].ToCharArray();
        //        karakter[0] = '*';
        //        karakter[karakter.Length - 1] = '*';
        //        kata[i] = new string(karakter);
        //    }
        //}
        Console.WriteLine("Hasil: " + hasil);
}

//    static void no4caralain()

//Console.WriteLine("Program Mengganti Awalan dan Akhiran");
//Console.Write("Input Kalimat : ");
//string kalimat = Console.ReadLine();

//string hasil = Gantihuruf(kalimat);

//Console.WriteLine("hasil : " + hasil);

//}
//static string Gantihuruf(string kalimat)
//{
//    string[] kata = kalimat.Split(' ');
//    string hasil = "";

//    for (int i = 0; i < kata.Length; i++)
//    {
//        string kataBaru = "";

//        for (int j = 0; j < kata[i].Length; j++)
//        {
//            if (j == 0 || j == kata[i].Length - 1)
//            {
//                kataBaru += "*";
//            }
//            else
//            {
//                kataBaru += kata[i][j];
//            }
//        }
//        hasil += kataBaru + " ";
//    }
//    return hasil.Trim();

//}



static void soal5()
{
    Console.WriteLine("Program Menghilangkan Awalan");
    a:
    Console.Write("Input kalimat : ");
    string word = Console.ReadLine();
    if (word == string.Empty)
    {
        Console.WriteLine("TIDAK BOLEH KOSONG!!!");
        goto a;
    }

    string[] katapecah = word.Split(' ');
    string hasil = "";

    for (int i = 0; i < katapecah.Length; i++)
    {
        string kataBaru = "";

        for (int j = 0; j < katapecah[i].Length; j++)
        {
            if (j == 0 || j == katapecah[i].Length + 1)
            {
                kataBaru += " ";
            }
            else
            {
                kataBaru += katapecah[i][j];
            }
        }
        hasil += kataBaru + " ";
    }
    Console.WriteLine("hasil : " + hasil);
}

static void soal6()
{
    int count = 0;
    Console.WriteLine("--Program Perkalian 3 Bintang--");
a:
    try
    {
        Console.WriteLine();
        Console.Write("Masukan angka : ");
        int input = int.Parse(Console.ReadLine());
        Console.Write("Input Bilangan Perkalian : ");
        int kali = int.Parse(Console.ReadLine());

        int x = 1;

        for (int i = 0; i < input; i++)
        {
            x *= kali;
            if (i % 2 == 0)
            {
                Console.Write($"{x} ");
            }
            else
            {
                Console.Write($"* ");
            }
        }
    }
    catch (Exception)
    {
        count++;
        
       
        if (count > 5)
        {
            Console.WriteLine("YANG BENER HEH!!!");
            throw; // untuk langsung keluar dari program
        }
        else
        {
            Console.WriteLine("Inputan Berupa Bilangan Bulat (TIDAK HURUF ATAUPUN PECAHAN!!!) & Tidak Kosong");
        }

        goto a;
    }
    

}


static void soal7()
{
    Console.WriteLine("Program Fibonaci");
    Console.Write("Inputkan Angka : ");
    int n = Convert.ToInt32(Console.ReadLine());
    n += 1;

    Console.WriteLine("Deret Fibonacci:");

    for (int i = 1; i < n; i++)
    {
        Console.Write(Fibonacci(i) + " ");
    }
}

static int Fibonacci(int n)
{
    if (n <= 1)
    {
        return n;
    }
    else
    {
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}

static void soal8()
{
    Console.WriteLine("--Soal Nomer 8--");
    Console.WriteLine();
    Console.Write("Masukan angka: ");
    int angka = int.Parse(Console.ReadLine());
    var x = angka;
    for (int i = 0; i < angka; i++)
    {
        for (int j = 0; j < angka; j++)
        {
            if (i == 0)
            {
                Console.Write($"{j + 1}\t");

            }
            else if (i == angka - 1)
            {
                //x -= 1;
                Console.Write($"{x}\t");
                x -= 1;
            }
            else if (j == 0 || j == angka - 1)
            {
                Console.Write($"*\t");
            }
            else
            {
                Console.Write($"\t");
            }
        }
        Console.WriteLine();

    }
}
