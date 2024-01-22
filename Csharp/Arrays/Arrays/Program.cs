// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//1. Tüm elemanları bildiğim durum:
string[] days = new string[] { "Monday", "Tuesday", "Wednesday" };
//days[3] = "Thursday";
//2. Sadece kapasitesini bildiğim durum:
string[] students = new string[9];

students[0] = "İrem";
students[1] = "Bertan";

Console.WriteLine(students[1]);





/*
 * Kullanıcının girdiği iki haneli sayının okunuşunu yazın.,
 *    42 ->Kırk iki
 *
 * 594.556.561.493
 *    
 */


string numberToString(int number)
{
    string[] onlar = { "", "on", "yirmi", "otuz", "kırk", "elli", "altmış", "yetmiş", "seksen", "doksan" };
    string[] birler = { "", "bir", "iki", "üç", "dort", "beş", "altı", "yedi", "sekiz", "dokuz" };

    var onlarDegeri = number / 10;
    var birlerDegeri = number % 10;

    return $"{onlar[onlarDegeri]} {birler[birlerDegeri]}";

}


do
{
    Console.WriteLine("Lütfen iki basamaklı bir sayı giriniz");

    int sayi = int.Parse(Console.ReadLine());
    //var onlarDegeri = sayi / 10;
    //var birlerDegeri = sayi % 10;

    //Console.WriteLine($"{onlar[onlarDegeri]} {birler[birlerDegeri]}");
    string okunus = numberToString(sayi);
    Console.WriteLine(okunus);

    Console.WriteLine("Tekrar sayı çevirecek misiniz? (E/H)");
} while (Console.ReadLine() == "E");


for (int i = 0; i < 100; i++)
{
    string result = numberToString(i);
    Console.WriteLine(result);
}





