//DAY 2 BITCHES//

//statementIF();
//statementIFelse();
//statementifelseif();
//statementNestedIF();
//statementternary();
//statementcase();
testing();

Console.ReadKey();

static void testing()
{
    Console.WriteLine("*******************************");
    Console.WriteLine("***WELCOME TO LANGUAGE CLASS***");
    Console.WriteLine("*******************************");
    Console.WriteLine();   
    Console.WriteLine("Please select option : 1 / 2");
    int ahli = int.Parse(Console.ReadLine());

    if (ahli == 1)
    {
        Console.WriteLine("Anda Memilih Kelas Bahasa Pemrograman");
        Console.WriteLine();
        Console.WriteLine("Pilih Bahasa yang Ingin anda pelajari : ");
        Console.WriteLine("(JAVA-----PHP------.NET)");
        string bahasa = Console.ReadLine().ToLower();

        switch (bahasa)
        {
            case "java":
                {
                    Console.WriteLine("Anda Memilih Bahasa Java");
                }
                break;
            case "php":
                { Console.WriteLine("Anda Memilih Bahasa PHP"); }
                break;
            case ".net":
                { Console.WriteLine("Anda Memilih Bahasa .Net"); }
                break;
        }
    }
    else if(ahli == 2)
    {
        Console.WriteLine("Anda Memilih Kelas Bahasa Internasional");
        Console.WriteLine();
        Console.WriteLine("Pilih Bahasa yang Ingin anda pelajari : ");
        Console.WriteLine("(Inggris-----Spanyol------Arab)");
        string bahasa = Console.ReadLine().ToLower();

        switch (bahasa)
        {
            case "inggris":
                {
                    Console.WriteLine("Anda Memilih Bahasa Inggris");
                }
                break;
            case "spanyol":
                { Console.WriteLine("Anda Memilih Bahasa Spanyol"); }
                break;
            case "arab":
                { Console.WriteLine("Anda Memilih Bahasa Arab"); }
                break;
        }
    }


    else
    { Console.WriteLine("Anda Tidak Memilih"); }
    Console.WriteLine('\n');
    Console.WriteLine("Terimakasih Telah Memilih Kelas yang Anda Inginkan");
    
}
static void statementcase()
{
    Console.WriteLine("PENGGUNAAN SWITCH");
    Console.WriteLine();
    Console.Write("Choose ur favourite fruit (apel/jeruk/pisang) : ");
    string pilihan = Console.ReadLine().ToLower();

    switch (pilihan)
    {
        case "apel":
            {
                Console.WriteLine("U choose Apple");
            }
            break;
        case "jeruk":
            {
                Console.WriteLine("U choose orange");
            }
            break;
        case "pisang":
            { 
                Console.WriteLine("U choose banana");
            }
            break;
            default:
            {
                Console.WriteLine("Ur favourite fruit isn't on the list");
            }
            break;
    }
}
static void statementternary()
{
    string z;
    Console.WriteLine("Kondisi Ternary aka penyederhanaan fungsi if else");
    Console.Write("Input Nilai X = ");
    int x = int.Parse(Console.ReadLine());
    Console.Write("Input Nilai Y = ");
    int y = int.Parse(Console.ReadLine());

    if (y>x)
    {
        Console.WriteLine("Y lebih besar dari X");
    }
    else if (y == x)
    {
        Console.WriteLine("X dan Y nilainya sama");
    }
    else
    {
        Console.WriteLine("X lebih besar dari Y");
    }

    Console.WriteLine("INI DENGAN TERNAY :");
    z = (y > x) ? "Y lebih besar dari X" : (y == x) ? "X dan Y nilainya sama" : "x lebih besar dari y"; //ini versi di sederhanakannya
    Console.WriteLine(z);
}
static void statementNestedIF()
{
    Console.WriteLine("INI PENGGUNAAN Nested IF (IF DALAM IF)");
    Console.Write("Input Nilai X = ");
    int x = int.Parse(Console.ReadLine());

    if (x > 10)
    {
        Console.WriteLine("X is Greater Than  10");

        if (x % 2 == 0)
        {
            Console.WriteLine("Bilangan Genap");
        }
        else
        {
            Console.WriteLine("Bilangan Ganjil");
        }
        
    }
    else
    {
        Console.WriteLine("X is Under 10");
    }
    Console.WriteLine();
    Console.WriteLine("Press any button to Exit");

}
static void statementifelseif()
    {
        Console.WriteLine("INI PENGGUNAAN IF ELSE IF");
        Console.Write("Input Nilai X = ");
        int x = int.Parse(Console.ReadLine());


        if (x == 10)
        {
            Console.WriteLine("X is equal to 10");
        }
        else if (x > 5)
        {
            Console.WriteLine("X is grater than 10 ");
        }
        else  
        {
            Console.WriteLine("X less than 10 ");
        }
        Console.WriteLine();
        Console.WriteLine("Press any button to Exit");

}
static void statementIFelse()
{
    Console.WriteLine("INI PENGGUNAAN IF");
    Console.Write("Input Nilai X = ");
    int x = int.Parse(Console.ReadLine());

    if (x >= 10)
    {
        Console.WriteLine("X is Greater Than or equal 10");
    }
    else
    {
        Console.WriteLine("X is Under 10");
    }
    Console.WriteLine();
    Console.WriteLine("Press any button to Exit");

}
static void statementIF()
{
    Console.WriteLine("INI PENGGUNAAN IF");
    Console.Write("Input Nilai X = ");
    int x = int.Parse(Console.ReadLine());
    Console.Write("Input Nilai Y = ");
    int y = int.Parse(Console.ReadLine());  

    if (x >= 10)
    {
        Console.WriteLine("X is Greater Than or equal 10");
    }
    if (y <= 5) 
    {
        Console.WriteLine("Y less than or equal to 5");
    }
    Console.WriteLine();
    Console.WriteLine("Press any button to Exit");
    
}

