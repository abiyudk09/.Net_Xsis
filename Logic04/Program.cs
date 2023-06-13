using Logic04; // agar classnya bisa digunakan

// DAY 4 BITCHES //

//inisialarray();
//aksestaticarray();
//array2d();
inisialList();
//listclass();
//akseslist();
//insertlist();
//removelist();
//indexelemenlist();
//exdatetime();
//parsingdatetime();
//datetimeproperties();
//extimespan();

Console.ReadKey();

static void extimespan()
{
    DateTime date1 = new DateTime(2016, 1, 10, 11, 20, 30);
    DateTime date2 = new DateTime(2016, 2, 20, 12, 25, 35);

    //calculate 
    TimeSpan interval = date2 - date1;

    Console.WriteLine(" No of days : " + interval.Days);
    Console.WriteLine(" Total Nomor of days : " + interval.TotalDays);
    Console.WriteLine(" Number of Hours : " + interval.Hours);
    Console.WriteLine(" Total Number of Hours : " + interval.TotalHours);
    Console.WriteLine(" Number of Minutes : " + interval.Minutes);
    Console.WriteLine(" Total Number of Minutes : " + interval.TotalMinutes);
    Console.WriteLine(" Number of seconds : " + interval.Seconds);
    Console.WriteLine(" Total Number of seconds : " + interval.TotalSeconds);
    Console.WriteLine(" Number of Miliseconds : " + interval.Milliseconds);
    Console.WriteLine(" Total Number of Miliseconds : " + interval.TotalMilliseconds);
    Console.WriteLine(" Ticks : " + interval.Ticks);


}
static void datetimeproperties()
{
    Console.WriteLine("Properti Kalender");
    DateTime date = new DateTime(2023, 6, 2, 14, 49, 50);
    int tahun = date.Year;
    int bulan = date.Month;
    int hari = date.Day;
    int jam = date.Hour;
    int min  = date.Minute;
    int sec = date.Second;
    int weekday = (int)date.DayOfWeek;
    string hari1 = date.ToString("dddd");
    string hari2 = date.DayOfWeek.ToString();

    Console.WriteLine($"Tahun : {tahun}");
    Console.WriteLine($"Bulan : {bulan}");
    Console.WriteLine($"Hari : {hari}");
    Console.WriteLine($"jam : {jam}");
    Console.WriteLine($"Menit : {min}");
    Console.WriteLine($"Detik : {sec}");
    Console.WriteLine($"Weekday : {weekday}");
    Console.WriteLine($"Hari String : {hari1}");
    Console.WriteLine($"Hari String 2: {hari2}");
}
static void parsingdatetime()
{
    string datestring = "30/06/2023" ;
    DateTime date = DateTime.Parse(datestring); //ini harus sesuai dengan format tanggal di perangkat
   // DateTime date = DateTime.ParseExact(datestring, "dd/MM/yyyy",null); // ini di pastikan dulu format tanggalnya, di variabelnya jg harus sama
    Console.WriteLine(date);
}
static void exdatetime()
{
    Console.WriteLine("Program Membuat Tanggal dan Waktu");
    DateTime dt = new DateTime();
    Console.WriteLine(dt);

    DateTime dtnow = DateTime.Now.Date;
    Console.WriteLine(dtnow); //Cetak tanggal hari ini

    DateTime dt2 = new DateTime(2023, 12, 5);
    Console.WriteLine(dt2);

    DateTime dt3 = new DateTime(2023, 6, 2, 13, 26, 47);
    Console.WriteLine(dt3);
}
static void indexelemenlist()
{
    List<int> list = new List<int>();
    list.Add(1);
    list.Add(2);
    list.Add(3);

    int item = 3;
    int index = list.IndexOf(item);

    if(index != -1)
    {
        Console.WriteLine($"Element {item} is Found at index {index}");
    }

    for (int i = 0; i < list.Count; i++)

    {
        Console.WriteLine(list[i]);
    }
}
static void removelist()
{
    List<int> list = new List<int>();
    list.Add(1);
    list.Add(2);
    list.Add(3);
    list.Add(3);


    list.Remove(3); //remove hanya 1 dengan nilai data 
    list.RemoveAt(0);// remove berdasarkan index 

    for (int i = 0; i < list.Count; i++)

    {
        Console.WriteLine(list[i]);
    }
}
static void insertlist()
{
    List<int> list = new List<int>();
    list.Add(1);
    list.Add(2);
    list.Add(3);

    list.Insert(2, 4);

    for (int i = 0; i < list.Count; i++)

    {
        Console.WriteLine(list[i]);
    }


}
static void akseslist()
{
    Console.WriteLine("Program Untuk Mengakses list");
    //List<int> list = new List<int>() { 1, 2, 3};
    List<int> list = new List<int>();
    list.Add(0);
    list.Add(1);
    list.Add(2);

    Console.WriteLine(list[0]);
    Console.WriteLine(list[1]);
    Console.WriteLine(list[2]);

    foreach (int item in list)
    {
        Console.WriteLine(item);
    }
    for (int i = 0; i < list.Count; i++)

{
    Console.WriteLine(i);
}
}
static void listclass()
{
    Console.WriteLine("Program untuk memanggil list dengan class");
    List<Student> students = new List<Student>()
    {
        new Student(){Id = 1, Name ="John"},
        new Student(){Id = 2, Name ="Jane"},
        new Student(){Id = 3, Name ="Joe"}
    };
    Console.WriteLine($"Panjang data list Student = {students.Count}   ");
    foreach(Student item in students)
    {
        Console.WriteLine($"Id : {item.Id}, Name : {item.Name}");
    }

}
static void inisialList()
{
    Console.WriteLine("Inisialisasi List dan menambahkan ");
    List<string> list = new List<string>()
    {
        "John",
        "Jane",
        "Joe"
    };
    list.Add("Joko");

    Console.WriteLine(string.Join(", ", list));
}
static void array2d()
{
    Console.WriteLine("Program Membuat array 2 D");
    int[,] atahun = new int[3, 3]
    {
        {100,22,33 },
        {33,44,55 },
        {21, 31,41}
    };
    for (int i = 0; i < 3; i++)
    {
           for (int j = 0; j < 3; j++)
        {
            Console.WriteLine(atahun[i, j]);
        }
           Console.WriteLine();
    }

}
static void aksestaticarray()
{
    Console.WriteLine("Program Mengakses Elemen Array");
    int[] staticInArray = new int[3];
    staticInArray[0] = 1;
    staticInArray[1] = 2;
    staticInArray[2] = 3;
    

    Console.WriteLine(staticInArray[0]);
    Console.WriteLine(staticInArray[1]);
    Console.WriteLine(staticInArray[2]);
    Console.WriteLine();

    Console.WriteLine("Dengan Lopping");
    int[] array = { 2, 4, 5 };
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }

    string[] strArray = new string[]
    {
        "Mahesh Chand",
        "Mik",
        "Dinesh"
    };
    foreach (string item in strArray) 
    {
        Console.WriteLine(item);
    }
}
 
static void inisialarray()
{
    Console.WriteLine("Program Cara Syntax Array");
    int[] array = new int[5]; //cara 1
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Inputkan Data ke {i + 1} :");
        array[i] = int.Parse(Console.ReadLine());
    }
    int[] array2 = new int[5] {1, 2, 3, 4, 5}; //cara 2 dengan data telah di input
    int[] array3 = new int[] {1, 2, 3, 4, 5}; //cara 3 length di kosongin tapi data diinput
    int[] array4 = {1, 2, 3, 4, 5}; //cara 4 langsung input datanya aj    
    int[] array5;
    array5 = new int[5]{1, 2, 3, 4, 5}; //cara 5 length + data udh d input bedanya cuman di deklarasikan lagi aja

    Console.WriteLine(String.Join(" , ", array));
    Console.WriteLine(String.Join(" , ", array2));
    Console.WriteLine(String.Join(" , ", array3));
    Console.WriteLine(String.Join(" , ", array4));
    Console.WriteLine(String.Join(" , ", array5));
}