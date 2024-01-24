// See https://aka.ms/new-console-template for more information
using GenericTypes;
using System.Collections;

Console.WriteLine("Hello, World!");
void islemYap(object obj)
{
    Console.WriteLine(obj);
}




islemYap("test");
islemYap(9);
islemYap(false);
islemYap(new Random());

object obj = "deneme";

//boxing: bir veriyi (değer) doğrudan object tipine atamak.
//unboxing: object tipine atanmış bir değeri, orjinal tipe dönüştürmek

string realType = (string)obj;
//int realInt = (int)obj;

ArrayList arrayList = new ArrayList();

PointGeneric<int> point = new PointGeneric<int>();

bool isEqual<T>(T value1, T value2) where T : struct, IComparable<T>

{
    return value1.CompareTo(value2) == 0;
}


Console.WriteLine(isEqual(15, 10));
if (isEqual(10.0, 10.0))
{
    Console.WriteLine("Eşit");
}
else
{
    Console.WriteLine("Eşit değil");
}