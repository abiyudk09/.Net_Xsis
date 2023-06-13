// DAY 3 BITCHES //

//exwhile();
//exwhile2();
//exdowhile();
//exfor();
//exbreak();
//excontinue();
//fordalamfor();
exforeach();
//exstring();
//excontainstring();
//exSplitNJoin();
//exsubstring();
//toCharArray();
//convertstringarraytoint();
//convertall();

Console.ReadKey();

static void convertall()
{
    Console.WriteLine("Convert String array to int");
    Console.Write("Input  = ");
    string input = Console.ReadLine();
    int sum = 0;
    int[] arrayy = Array.ConvertAll(input.Split(" "), int.Parse);

    foreach (int x in arrayy)
    {
        sum += x;
    }
    Console.WriteLine($"jumlah = {sum} ");

}
static void convertstringarraytoint()
{
    Console.WriteLine("Convert String array to int");
    Console.Write("Input  = ");
    string input = Console.ReadLine();
    int sum = 0;
    string[] arrayy = input.Split(" ");
    
    foreach (string x in arrayy)
    {
       sum += Convert.ToInt32(x);
       //sum += int.Parse(x); pilih salah satu
    }
    Console.WriteLine($"jumlah = {sum} ");

}
static void toCharArray()
{
    Console.WriteLine("String to CharArray");
    Console.Write("Input Kalimat = ");
    string word = Console.ReadLine();

    char[] array = word.ToCharArray();

    foreach (char x in array)
    {
        Console.WriteLine(x);
    }

    //Console.WriteLine();

    //for (int i = 0; i < array.Length; i++)
    //{
    //    Console.WriteLine(array[i]);
    //}
}

static void exsubstring ()
{
    Console.Write("Input Code = ");
    string kode = Console.ReadLine ();
    Console.Write("input parameter 1 = ");
    int param1 = int.Parse(Console.ReadLine());
    Console.Write("input parameter 2 = ");
    int param2 = int.Parse(Console.ReadLine());

    if (param2 == 0)
    {
        Console.WriteLine($"Hasil Substring = {kode.Substring(param1)}");
    }
    else
    {
 
    Console.WriteLine($"Hasil Substring = {kode.Substring(param1, param2)}");
    }
  
}
static void exSplitNJoin()
{
    Console.WriteLine("Program Split n Join String");
    Console.Write("Input Kalimat = ");
    string word = Console.ReadLine();
    Console.Write("input Pemisah = ");
    string split = Console.ReadLine();

    string[] kalimat = word.Split(split);

    foreach (var kata in kalimat)
    {
        Console.WriteLine(kata);
    }

    Console.WriteLine(string.Join(" + ", kalimat));
    
}
static void excontainstring()
{
    Console.WriteLine("__CONTAIN STRING__");
    Console.Write("Input Kata = ");
    string kata = Console.ReadLine();
    Console.Write("Input Contain = ");
    string contain =    Console.ReadLine();

    if (kata.Contains(contain))
    {
        Console.WriteLine($"Kata {kata} mengandung {contain}");
    }
    else
    {
        Console.WriteLine($"Kata {kata} tidak mengandung {contain}");
    }
    
}
static void exstring()
{
    Console.WriteLine(" Program To Manipulate String Word");
    Console.Write("Input Kata = ");
    string kata = Console.ReadLine();   

    Console.WriteLine($"Kata {kata} memiliki panjang karakter = {kata.Length}\n"  ); // Menghitung Panjang Kata
    // kata.ToUpper () buat KAPITAL SEMUA
    // kata.ToLower () buat mengecilkan semua

    //REMOVE STRING//

    Console.WriteLine("--FUNGSI REMOVE STRING--");
    Console.Write("Input Indeks REMOVE : ");
    int index = int.Parse(Console.ReadLine());

    Console.WriteLine($"{kata.Remove(index)}\n");


    //INSERT STRING//

    Console.WriteLine("--FUNGSI INSERT STRING--");
    Console.Write("Input Indeks Insert : ");
    int indexin = int.Parse(Console.ReadLine());
    Console.Write("Input Kata Insert : ");
    string intsert = Console.ReadLine();

    Console.WriteLine($"{kata.Insert(indexin, intsert)}\n");

    //REPLACE STRING//

    Console.WriteLine("--FUNGSI REPLACE STRING--");
    Console.Write("Input Kata yang akan di ganti = ");
    string katalama = Console.ReadLine();
    Console.Write("Input Kata Baru = ");
    string katabaru = Console.ReadLine();

    Console.WriteLine($"{kata.Replace(katalama, katabaru)}");

}
static void exforeach()
{
    int[] iniarray = { 89, 90, 91, 92, 93 };
    int sum = 0, jum = 0;

    foreach (int i in iniarray)
    {
        
        Console.WriteLine(i);
        sum += i;
    }
    Console.WriteLine($"JUMLAH = {sum}");
    
    Console.WriteLine();

    for (int i = 0; i < iniarray.Length; i++)
    {
        Console.WriteLine(iniarray[i]);
        jum += iniarray[i];
    }
    Console.WriteLine($"Jumlah = {jum}");
}
static void fordalamfor()
{
    for (int i = 0; i < 3; i++) //BUAT BARIS
    {
        for (int j = 0; j < 3; j++) //BUAT KOLOM
        {
            //INI KALO MAU TENGAHNYA KOSONG
            //if(i == 1 && j == 1 )
            //{
            //    Console.Write("\t  ");
            //    continue;
                
            //}

            Console.Write($"({i},{j})");
        }
        Console.WriteLine();
    }
}
static void excontinue()
{
    for (int i = 0; i < 10; i++)
    {
        
        if (i == 7)
        {
            continue;
        }
        Console.WriteLine(i);
    }
}
static void exbreak()
{
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine(i);
        if(i == 7)
        {
            break;
        }
    }
}
static void exfor()
{
    for (int i = 0; i < 5; i++)
    {
        Console.Write(i + " \n \t ");
    }

    Console.WriteLine("\n");   

    for (int i = 9; i >= 0; i--)
    {
        Console.WriteLine(i);
    }
}
static void exdowhile()
{
    Console.WriteLine("Contoh Do While ");
    Console.Write("Input Nilai = "  );
    int nilai = int.Parse( Console.ReadLine() );

    do
    {
        Console.WriteLine(nilai );
        nilai++;

    } while (nilai < 7);
}
static void exwhile2()
{
    bool ulangi = true;

    Console.WriteLine("Contoh While 2");
    Console.Write("Input Nilai = ");
    int nilai = int.Parse(Console.ReadLine());

    while (ulangi)
    {
        Console.WriteLine($"Proses ke {nilai}   ");
        nilai++;

        Console.Write("ulangi proses ? (y/n) : ");
        string input = Console.ReadLine();

        if (input.ToLower() == "y") 
        {
            ulangi = true;
        }
        else if (input.ToLower() == "n")
        {
            ulangi = false;
        }
        else
        {
            Console.WriteLine("INVALID");
            ulangi = false;
        }
    }
}
static void exwhile()
{
    Console.WriteLine("Program Contoh While ");
    //int nilai = 1; // kalo mau tanpa inputan
    Console.Write("Input Nilai = ");
    int nilai = int.Parse(Console.ReadLine());

    while (nilai < 6)
    {
        Console.WriteLine(nilai);
        nilai ++;
    }
}