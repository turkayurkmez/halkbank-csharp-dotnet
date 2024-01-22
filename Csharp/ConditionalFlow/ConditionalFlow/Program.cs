Console.WriteLine("şu seçeneklerden birini girin: kirmizi, sari, yesil");
string trafikLambasi = Console.ReadLine();

if (trafikLambasi == "kirmizi")
{
    Console.WriteLine("dur");
}
else if (trafikLambasi == "sari")
{
    Console.WriteLine("bekle");

}
else if (trafikLambasi == "yesil")
{
    Console.WriteLine("geç");

}
else
{
    Console.WriteLine("hatalı giriş");
}


switch (trafikLambasi)
{
    case "kirmizi":
        Console.WriteLine("dur");

        break;
    case "sari":
        Console.WriteLine("bekle");

        break;
    case "yesil":
        Console.WriteLine("geç!");

        break;
    default:
        break;
}