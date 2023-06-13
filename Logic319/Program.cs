// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.Write("test");
Console.Write("test");
Console.WriteLine("test");
Console.Write("GASS");
Console.WriteLine();

Console.WriteLine("---Bio NIH---");
Console.Write("Nama\t: ");
string nama = Console.ReadLine();
Console.Write("Umurnya\t: ");
string age = Console.ReadLine();
//berbagai cara manggil 
Console.WriteLine("Hola {0}, Wasssup bro", nama);
Console.WriteLine($"Hola {nama}, Wasssup bro");
Console.WriteLine("umur gue " + age +" tahun");
//
Console.WriteLine("Hobi\t: Push Rank ");
Console.WriteLine();

//tipe data implisit
var web = "www.blogspot.com";
var umur = 22;
var menikah = false;
Console.WriteLine("Nama\t : " + web);
Console.WriteLine("Age\t : " + umur);
Console.WriteLine("Married\t : " + menikah);

//var immutable
//const double phi = 3.14;



Console.ReadKey();