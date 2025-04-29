using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstution
{
    public abstract class Document
    {
        public abstract void Open();
        public abstract void Save();

    }

    public interface IPrintable
    {
        void Print();
    }

    public class ExcelDocument : Document, IPrintable
    {
        public override void Open()
        {
            Console.WriteLine("Excel açıldı");
        }

        public void Print()
        {
            Console.WriteLine("Excel çıktı alındı");
        }

        public override void Save()
        {
            Console.WriteLine("Excel kaydedildi");
        }
    }

    public class WordDocument : Document, IPrintable
    {
        public override void Open()
        {
            Console.WriteLine("Word açıldı");
        }

        public void Print()
        {
            Console.WriteLine("Word çıktı alındı");
        }

        public override void Save()
        {
            Console.WriteLine("Word kaydedildi");
        }
    }

    public class PDFDocument : Document
    {
        public override void Open()
        {
            Console.WriteLine("PDF açıldı");
        }



        public override void Save()
        {
            Console.WriteLine("PDF kaydedildi");
        }
    }

    public class DocumentPrinter
    {
        public void Print(IPrintable document)
        {
            document.Print();
        }
    }

}
