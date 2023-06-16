// DAY 5 BITCHES //

//PadLeft();
rekursif();
//rekursif1();


Console.ReadKey();

static void rekursif1()
{
    Console.WriteLine("Program Rekursif Descending (besar ke kecil) ");
    Console.Write("Input angka : ");
    int input = int.Parse(Console.ReadLine());
    Console.Write("Masukkan Batas : ");
    int batas = int.Parse(Console.ReadLine());

    if (input <= batas)
    {
        //  panggil fungsi
        perulangan1(input, batas);
    }
    else
    {
        Console.WriteLine("Input tidak boleh lebih besar dari batas ");
    }



}
static int perulangan1(int input, int batas)
{

    if (batas == input)
    {
        Console.WriteLine(batas);
        return batas;
    }

    Console.WriteLine(batas);
    return perulangan1(input, batas - 1);
}
static void rekursif()
{
    Console.WriteLine("Program Rekursif Ascending (kecil ke besar) ");
    Console.Write("Input angka : ");
    int input = int.Parse(Console.ReadLine());
    Console.Write("Masukkan Batas : ");
    int batas = int.Parse(Console.ReadLine());

    if (input <= batas)
    {
        //  panggil fungsi
        perulangan(input, batas);
    }
    else
    {
        Console.WriteLine("Input tidak boleh lebih besar dari batas ");
    }



}
static int perulangan(int input, int batas)
{

    if (input == batas)
    {
        Console.WriteLine(input);
        return input;
    }

    Console.WriteLine(input);
    return perulangan(input + 1, batas);
}
static void PadLeft()
{
    Console.WriteLine("Program PadLeft & PadRight");
    Console.Write("Input : ");
    int input = int.Parse   (Console.ReadLine()); //kalo gini int input - console.Read gunanya buat yg integer ajaa
    Console.Write("Input Panjang Karakter : ");
    int panjang = int.Parse(Console.ReadLine());
    Console.Write("Input Karakter : ");
    char chars = char.Parse (Console.ReadLine());

    //230600005 -> 2 digit tahun + bulan 2 digit + generate length 5

    DateTime date = DateTime.Now;
    string codeL = "";
    string codeR = "";

    codeL = date.ToString("yy") + date.ToString("MM") + input.ToString().PadLeft(panjang, chars);
    codeR = date.ToString("yy") + date.ToString("MM") + input.ToString().PadRight(panjang, '0');

    Console.WriteLine($"Hasil dari Padleft : {codeL}");
    Console.WriteLine($"Hasil dari Padright : {codeR}");
}

