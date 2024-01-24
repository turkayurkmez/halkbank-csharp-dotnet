using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractVSInterface
{
    public abstract class Document
    {
        public string Title { get; set; }
        public string Creator { get; set; }
        public void Copy(string from, string to)
        {
            Console.WriteLine("kopyalandı");
        }

        public void Move(string from, string to)
        {
            Console.WriteLine("taşındı");
        }

        public abstract void Save();
        public abstract void Load();
        public abstract void Print();


    }

    public class WordDocument : Document
    {
        public override void Load()
        {
            throw new NotImplementedException();
        }

        public override void Print()
        {
            Console.WriteLine("Word çıktısı alındı");
        }

        public override void Save()
        {
            throw new NotImplementedException();
        }
    }

    public class ExcelDocument : Document
    {
        public override void Load()
        {
            throw new NotImplementedException();
        }

        public override void Print()
        {
            Console.WriteLine("Excel çıktısı alındı");

        }

        public override void Save()
        {
            throw new NotImplementedException();
        }
    }

    public class PdfDocument : Document
    {
        public override void Load()
        {
            throw new NotImplementedException();
        }

        public override void Print()
        {
            Console.WriteLine("PDF çıktısı alındı");

        }

        public override void Save()
        {
            throw new NotImplementedException();
        }
    }


    public class PrinterComponent
    {
        public void Print(Document document)
        {
            document.Print();
        }
    }
}
