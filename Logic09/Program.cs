// DAY 9 BITCHES //

//Fungsimath();
tesgrading();

Console.ReadKey();

static void Fungsimath()
{
    Console.WriteLine("--Program Fungsi Math--");
    Console.Write("Inputkan Angka : ");
    float angka = float.Parse(Console.ReadLine());

    Console.WriteLine($"Hasil Fungsi Abs  : {Math.Abs(angka)}"); //(Mengubah nilai - ke +)
    Console.WriteLine($"Hasil Fungsi Round : {Math.Round(angka)}"); //(Membulatkan nilai)
    Console.WriteLine($"Hasil Fungsi Round 2 digit : {Math.Round(angka, 2)}"); //(Membulatkan nilai dengan ditentukan brp digit d belakang ,)
    Console.WriteLine($"Hasil Fungsi Round 2 digit : {Math.Round(angka, 2, MidpointRounding.ToNegativeInfinity)}"); //(Membulatkan ke bawah nilai dengan ditentukan brp digit d belakang)
    Console.WriteLine($"Hasil Fungsi Round 2 digit : {Math.Round(angka, 2, MidpointRounding.ToPositiveInfinity)}"); //(Membulatkan ke atas nilai dengan ditentukan brp digit d belakang)
    Console.WriteLine($"Hasil Fungsi Pow  : {Math.Pow(angka, 3)}"); //untuk fungsi pangkat
}

//  HACKERRANK WARMUP TEST //

//grading 

static void tesgrading()
{
    Console.WriteLine("Program grading nilai Hackerrank");
    Console.Write("Input Panjang list : ") ;
    int panjang = int.Parse(Console.ReadLine());
    Console.Write("Inputkan Nilai : ");
    string[] nilai = Console.ReadLine().Split(" ") ;
    int[] grade = Array.ConvertAll(nilai, int.Parse) ;

    for (int i = 0; i < nilai.Length; i++)
    {
        if (grade[i] >= 38 && grade[i] < 100)  
        {
            if ((grade[i] + 2) % 5 == 0)
            {
                grade[i] += 2;
            }
            else if ((grade[i] + 1) % 5 == 0)
            {
                grade[i] += 1;
            }
        }

    }
    Console.WriteLine(String.Join("\n", grade));
    

}