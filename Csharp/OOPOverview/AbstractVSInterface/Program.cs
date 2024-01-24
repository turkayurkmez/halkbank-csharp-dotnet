// See https://aka.ms/new-console-template for more information
using AbstractVSInterface;

Console.WriteLine("Hello, World!");
WordDocument word = new WordDocument();
ExcelDocument excel = new ExcelDocument();
PdfDocument pdf = new PdfDocument();

PrinterComponent printer = new PrinterComponent();
printer.Print(word);
printer.Print(excel);
//printer.Print(pdf);