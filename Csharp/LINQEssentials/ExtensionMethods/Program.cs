// See https://aka.ms/new-console-template for more information
using ExtensionMethods;

Console.WriteLine("Hello, World!");

int x = 5;
Console.WriteLine(x.GetSquare());
string tableName = "Order Details";
Console.WriteLine(tableName.RemoveEmptySpaces());

string isim = "mehmet ali birand";
Console.WriteLine(isim.ToTitleCase());

Console.WriteLine(new Random().NextString(8, true));