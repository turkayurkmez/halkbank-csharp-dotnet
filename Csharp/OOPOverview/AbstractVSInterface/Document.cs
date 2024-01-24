using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractVSInterface
{
    public interface IPrintable
    {
        void Print();
    }

    public interface IAttachable
    {
        void Attach();
    }

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
        //public abstract void Print();


    }

    public class WordDocument : Document, IPrintable, IAttachable
    {
        public void Attach()
        {
            throw new NotImplementedException();
        }

        public override void Load()
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            Console.WriteLine("Word çıktısı alındı");
        }

        public override void Save()
        {
            throw new NotImplementedException();
        }
    }

    public class ExcelDocument : Document, IPrintable
    {
        public override void Load()
        {
            throw new NotImplementedException();
        }

        public void Print()
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


        public override void Save()
        {
            throw new NotImplementedException();
        }
    }


    public class PrinterComponent
    {
        public void Print(IPrintable document)
        {
            document.Print();
        }
    }
}
