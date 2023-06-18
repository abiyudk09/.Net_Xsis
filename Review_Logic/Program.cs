//Review Soa Logic//


//Review1();
Review2();

Console.ReadKey();

//No 1
static void Review1()
{
    Console.WriteLine("Program untuk Membuat nomor invoice");
    Console.Write("Inputkan Inisial Perusahaan  : ");
    string inisial = Console.ReadLine();
    Console.Write("Inputkan Angka : ");
    int ang = int.Parse(Console.ReadLine());
    Console.Write("Inputkan Banyaknya : ");
    int banyak = int.Parse(Console.ReadLine());

    for (int i = ang; ang <= banyak; ang++)
    {
        DateTime date = DateTime.Now;

        string code = "";

        code = inisial.ToString() + "-" + date.ToString("ddMMyyyy")  + "-" + ang.ToString().PadLeft(5, '0');
        Console.WriteLine(code);
    }
}

static void Review2()
{
    Console.Write("Masukan Input : ");
    string[] input = Console.ReadLine().Split(',');

    int angka1 = int.Parse(input[0]);
    int angka2 = int.Parse(input[1]);

    char[] angkachar = angka1.ToString().ToCharArray();

    int sum = 0;

    for (int i = 0; i < angka2; i++)
    {
        for (int j = 0; j < angkachar.Length; j++)
        {
            sum += int.Parse(angkachar[j].ToString());
        }
    }

    char[] baru = sum.ToString().ToCharArray();

    int hasil = 0;

    for (int k = 0; k < baru.Length; k++)
    {
        hasil += int.Parse(baru[k].ToString());
    }

    Console.WriteLine($"Hasilnya Adalah : {hasil} ");


    //cara farhi
    //    string array;
    //    int sum = 0;
    //    Console.WriteLine("--==RECURSIVE DIGIT==--");
    //    Console.Write("Insert values and Recursive (153, 3) : ");
    //    array = Console.ReadLine();
    //    int[] new_array = Array.ConvertAll(array.Split(", "), int.Parse);

    //    int number = new_array[0];
    //    int looping = new_array[1];
    //    int result = 0;
    //    for (int i = 0; i < looping; i++)
    //    {
    //        sum += RecursiveFunction(number);

    //    }

    //    Console.WriteLine(sum);

    //    char[] new_sum = sum.ToString().ToCharArray();

    //    foreach (char i in new_sum)
    //    {
    //        Console.WriteLine(i);
    //        result += int.Parse(i.ToString());

    //    }
    //    Console.WriteLine(result);
    //}
    //static int RecursiveFunction(int number)
    //{
    //    if (number == 0)
    //        return 0;
    //    return (number % 10 + RecursiveFunction(number / 10));


    // cara alif
    //    Console.WriteLine("Program Membuat Rekursif Digit");
    //    Console.Write("Masukkan angka dan jumlah perulangan (misal: 153, 3): ");
    //    string input = Console.ReadLine();

    //    string[] splitInput = input.Split(',');
    //    int number = int.Parse(splitInput[0]);
    //    int iterations = int.Parse(splitInput[1]);

    //    int result = RecursiveDigitSum(number, iterations);
    //    Console.WriteLine("Hasil penjumlahan digit: " + result);
    //}

    //static int RecursiveDigitSum(int number, int iterations)
    //{
    //    if (iterations == 0)
    //        return number;

    //    int sum = 0;
    //    string numberString = number.ToString();

    //    for (int i = 0; i < numberString.Length; i++)
    //    {
    //        sum += int.Parse(numberString[i].ToString());
    //    }

    //    return RecursiveDigitSum(sum, iterations - 1);

}