using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            IPrintable word = new Word();
            IPrintable pdf = new PDF();
            IPrintable excel = new Excel();
            MainPrintFile word1 = new MainPrintFile(word);
            MainPrintFile excel1 = new MainPrintFile(excel);
            MainPrintFile pdf1 = new MainPrintFile(pdf);


        }
    }
}
