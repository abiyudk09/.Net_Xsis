// Tes Latihan //

//prima();
camelcase();

Console.ReadKey();


static void password()
{
    Console.WriteLine("Programm Password");
    Console.Write("Inputkan Password : ");
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