
using System.Text.RegularExpressions;

//no1();
//no4();
//no2();
//no10();
//no5();
//no3();
//no7();
//no8();

Console.ReadKey();


static void no1()
{
    Console.WriteLine("Program Penjumlahan");
    Console.Write("Inputkan Bilangan (pisahkan dengan spasi): ");
    string input = Console.ReadLine();
    string[] arr = input.Split(' ');

    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        int jum = int.Parse(arr[i]);

        sum += jum;

        if (i == 0)
        {
            Console.WriteLine(jum);
        }
        else
        {
            string output = arr[0];
            for (int j = 1; j <= i; j++)
            {
                output += "+" + arr[j];
            }
            output += " = " + sum;
            Console.WriteLine(output);
        }
    }
}

static void no4()
{

        Console.Write("N : ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("X : ");
        int x = int.Parse(Console.ReadLine());

        int lembar;

        if (x % 2 == 1)
        {
            lembar = x / 2 + 1;
        }
        else
        {
            lembar = x / 2;
        }

        Console.WriteLine("lembar ke-{1}.", x, lembar);
}

static void no2()
{
    Console.WriteLine("Program Password");
    Console.Write("Inputkan password: ");
    string password = Console.ReadLine();

    if (IsValidPassword(password))
    {
        Console.WriteLine("Valid");
    }
    else
    {
        Console.WriteLine("Invalid");
    }
}

static bool IsValidPassword(string password)
{
    // Periksa panjang karakter
    if (password.Length < 5 || password.Length > 10)
    {
        return false;
    }

    // Periksa karakter alfanumerik dan (_)
    foreach (char c in password)
    {
        if (!char.IsLetterOrDigit(c) && c != '_')
        {
            return false;
        }
    }

    return true;
}


static void no10()
{
    Console.Write("Input kalimat: ");
    string kalimat = Console.ReadLine();

    int countKonsonan = 0;
    string vokal = "aiueoAIUEO";
    bool prevIsVokal = false;

    for (int i = 0; i < kalimat.Length; i++)
    {
        char huruf = char.ToLower(kalimat[i]);

        if (char.IsLetter(huruf))
        {
            if (!vokal.Contains(huruf))
            {
                if (prevIsVokal)
                {
                    countKonsonan++;
                }
            }
            else
            {
                prevIsVokal = true;
            }
        }
        else
        {
            prevIsVokal = false;
        }
    }

    Console.WriteLine($"Jumlah huruf konsonan dengan huruf vokal sebelumnya: {countKonsonan - 1}");
}

static void no5()
{
    Console.WriteLine("Masukkan total penduduk (n):");
    int n = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Masukkan jumlah calon anggota legislatif (m):");
    int m = Convert.ToInt32(Console.ReadLine());

    List<int> votes = GenerateRandomVotes(n, m);
    List<double> percentages = CalculatePercentages(votes, n);


    PrintElectionResults(votes, percentages);



}

static List<int> GenerateRandomVotes(int n, int m)
{
    List<int> votes = new List<int>();
    Random random = new Random();

    int remainingVotes = n;
    for (int i = 0; i < m - 1; i++)
    {
        int candidateVotes = random.Next(0, remainingVotes + 1);
        votes.Add(candidateVotes);
        remainingVotes -= candidateVotes;
    }

    votes.Add(remainingVotes);  // Last candidate gets the remaining votes

    return votes;
}

static List<double> CalculatePercentages(List<int> votes, int totalVotes)
{
    List<double> percentages = new List<double>();

    foreach (int vote in votes)
    {
        double percentage = Math.Round((double)vote / totalVotes * 100, 2);
        percentages.Add(percentage);
    }

    return percentages;
}

static void PrintElectionResults(List<int> votes, List<double> percentages)
{
    int m = votes.Count;

    for (int i = 0; i < m; i++)
    {
        int candidateNumber = i + 1;
        int candidateVotes = votes[i];
        double candidatePercentage = percentages[i];

        Console.WriteLine($"Calon no. urut {candidateNumber}: {candidateVotes} suara ({candidatePercentage} %)");
    }

    int golputVotes = votes[votes.Count - 1];  // Last candidate is considered golput
    double golputPercentage = percentages[percentages.Count - 1];

    Console.WriteLine($"Golput: {golputVotes} suara ({golputPercentage} %)");
}


static void no3()
{

    Console.WriteLine("Soal3");
    Console.Write("Masukkan Inputan: ");
    string inputAwal = Console.ReadLine();
    Console.Write("Masukkan Jumlah Pemisah: ");
    int pemisah = int.Parse(Console.ReadLine());

    List<string> kataTerpisah = SplitWords(inputAwal, pemisah);
    kataTerpisah.RemoveAll(kata => kata.Length < pemisah);
    kataTerpisah.Sort();

    Console.WriteLine("Output:");
    foreach (string kata in kataTerpisah)
    {
        Console.WriteLine(kata);
    }
}

static List<string> SplitWords(string inputAwal, int pemisah)
{
    List<string> kataTerpisah = new List<string>();

    string[] kataArray = inputAwal.Split(' ');

    foreach (string kata in kataArray)
    {
        if (kata.Length >= pemisah)
        {
            for (int i = 0; i <= kata.Length - pemisah; i++)
            {
                string kataPemisah = kata.Substring(i, pemisah);
                kataTerpisah.Add(kataPemisah);
            }
        }
    }

    return kataTerpisah;

}


static void no7()
{
    Console.WriteLine("Program Cleansing : ");
    Console.Write("Masukkan kata atau kalimat: ");
    string input = Console.ReadLine();

    string cleanedString = CleanseString(input);

    Console.WriteLine("Output: " + cleanedString);

    Console.ReadLine();
}

static string CleanseString(string input)
{
    // Menghapus koma (,), kutip satu ('), kutip dua ("),
    // anotasi (@), kata yang sama, garis miring (/), dan (&)
    string pattern = @"[,'""@/&]|(\b\w+\b)(?=.*\b\1\b)";
    string cleanedString = Regex.Replace(input, pattern, "");

    return cleanedString;
}

static void no8()
{
    Console.WriteLine("--Soal Sembilan Cara 2--");
    Console.Write("Masukkan Pola : ");
    string pola = Console.ReadLine();
    Console.Write("Masukkan action : ");
    string action = Console.ReadLine();


    int[,] angkaArr = {
        { 0, 1, 2 },       // (0,0) (0,1) (0,2)
        { 3, 4, 5 },        // (1,0) (1,1) (1,2)
        { 6, 7, 8 } };   // (2,0) (2,1) (2,2)

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

    int perbedaan = diagonalPertama + diagonalKedua;

    Console.WriteLine($"Diagonal pertama: {dayaTampungDP} = {diagonalPertama}");
    Console.WriteLine($"Diagonal kedua: {dayaTampungDK} = {diagonalKedua}");
    Console.WriteLine();
    Console.WriteLine($"Perbedaan |{dayaTampungDP}| + |{dayaTampungDK}| = {perbedaan}");


}