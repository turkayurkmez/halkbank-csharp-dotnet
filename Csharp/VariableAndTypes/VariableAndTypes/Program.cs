// See https://aka.ms/new-console-template for more information
using System.Drawing;

Console.WriteLine("........ Değişkenler ............");
//Primitive type: Sadece birim değer için oluşturulmuş tipler.

/*
 *  Sayısal
 *    Tam Sayılar *    
 *    Ondalıklı sayılar
 *  
 *  Sözel
 *     
 *  
 *  Mantıksal
 *  
 */

byte miniInteger = 255;
sbyte possiblyNegative = -127;

short sixteenBit = 32767;
ushort unsignedShort = 65535;


//int, uint, long, ulong

//Ondalıklı
double pi = 3.14;
float floatPi = 3.14f;
decimal decimalPi = 3.145946789610666514444044646404945411548962033266564M;

//Sözel:
char character = '{';
string companyName = "Halkbank";

//Point point = new Point();
//Point point2 = new Point();
//Mantıksal veri tipi:
bool isSuccess = true;

byte number = 100;
int implicitCasting = number;

int minimum = 510;
byte explicitCasting = (byte)minimum;

Console.WriteLine(explicitCasting);

try
{
    Console.WriteLine("Bir sayı giriniz:");
    var number1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Bir sayı daha giriniz:");
    var number2 = int.Parse(Console.ReadLine());
    checked
    {
        byte total = (byte)(number1 + number2);
        Console.WriteLine($"Toplam: {total} ");

        byte division = (byte)(number1 / number2);
        Console.WriteLine($"Bölüm sonucu: {division}");

    }

}
catch (FormatException)
{

    Console.WriteLine("Sayı girilmediği için hata oluştu");
}
catch (OverflowException)
{
    Console.WriteLine("Girdiğiniz değerler toplamı, byte sınırlarında olmalı");
}
catch (DivideByZeroException)
{
    Console.WriteLine("0'a bölünemez");
}










