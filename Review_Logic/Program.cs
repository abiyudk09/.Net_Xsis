//Review Soa Logic//


//Review1();
Review2();

Console.ReadKey();

//No 1
static void Review1()
{
    Console.WriteLine("Program untuk Membuat nomor invoice");
    Console.Write("Inputkan Inisial Perusahaan (2Huruf) : ");
    string inisial = Console.ReadLine();
    Console.Write("Inputkan Angka : ");
    int ang = int.Parse(Console.ReadLine());
    Console.Write("Inputkan Banyaknya : ");
    int banyak = int.Parse(Console.ReadLine());

    for (int i = ang; ang <= banyak; ang++)
    {
        DateTime date = DateTime.Now;

        string code = "";

        code = inisial.ToString() + "-" + date.ToString("dd") + date.ToString("MM") + date.ToString("yy") + "-" + ang.ToString().PadLeft(5, '0');
        Console.WriteLine(code);
    }
}

static void Review2()
{
    Console.WriteLine("Program Membuat Rekursif Digit");
    Console.Write("");

}