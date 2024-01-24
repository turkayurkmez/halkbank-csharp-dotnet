// See https://aka.ms/new-console-template for more information
using WhatIsDelegate;

Console.WriteLine("Hello, World!");

int[] numbers = Enumerable.Range(0, 11).ToArray();
//.NET 1.1
var evenNumbers = FilterHelper.Filter(numbers, isEven);
//.NET 2.0
var oddNumbers = FilterHelper.Filter(numbers,
delegate (int number)
{
    return number % 2 == 1;
});

//.NET 3.5
var lessThanFive = FilterHelper.Filter(numbers, n => n < 5);


Console.WriteLine("çift sayılar");
show(evenNumbers);
Console.WriteLine("tek sayılar");
show(oddNumbers);
Console.WriteLine("5'den küçükler");
alternateShow(lessThanFive);







bool isEven(int number)
{
    return number % 2 == 0;
}

void show(int[] numbers)
{
    foreach (var item in numbers)
    {
        Console.WriteLine(item);
    }
}

void alternateShow(int[] numbers)
{
    numbers.ToList().ForEach(n => showNumber(n));
}

void showNumber(int n)
{
    Console.WriteLine(n);
}