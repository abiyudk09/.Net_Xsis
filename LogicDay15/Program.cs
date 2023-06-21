// Tes Latihan //

//prima();
//camelcase();
password();

Console.ReadKey();


static void password()
    {
        Console.WriteLine("Programm Password");
        Console.Write("Inputkan Password : ");
        string pass = Console.ReadLine();

    string numbers = "0123456789";
    string lower_case = "abcdefghijklmnopqrstuvwxyz";
    string upper_case = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    string special_characters = "!@#$%^&*()-+";

    int result = 0;

    int no = 1, lower = 1, upper = 1, schar = 1;

    List<char> arr = pass.ToList();

    for (int i = 0; i < arr.Count; i++)
    {
            
        {
            no = 0;
        }
        else if (lower_case.Contains(arr[i]) && lower == 1)
        {
            lower = 0;
        }
        else if (upper_case.Contains(arr[i]) && upper == 1)
        {
            upper = 0;
        }
        else if (special_characters.Contains(arr[i]) && schar == 1)
        {
            schar = 0;
        }

    }
    result = Math.Max(6 - arr.Count, no + lower + upper + schar);

    Console.WriteLine($"Hasil = {result}");
}


static void camelcase()
{
    Console.WriteLine("Programm Camel Case");
    Console.Write("Inputkan Kata : ");
    string input = Console.ReadLine();
    char[] kata = input.ToCharArray();

    int result= 1;
    for (int i = 0; i < kata.Length-1; i++)
    {
        if (char.IsUpper(kata[i]))
        {
        result++;
        }

    }
    Console.WriteLine(result);
}


static void prima()
{
    Console.WriteLine("Programm Untuk Menentukan Bilangan Prima");
    Console.Write("Inputkan Angka : ");
    int n = int.Parse(Console.ReadLine());

    string x = "";
    for (int i = 2; i <= n; i++)
    {
        int count = 0;
        for (int j = 2; j <= n; j++)
        {
            if (i % j == 0)
            {
                count++;
            }
        }
        if (count == 1)
        {
            x += x == "" ? i : ", " + i ;
        }

    }
    Console.WriteLine(x);
}
