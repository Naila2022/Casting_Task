using System;
namespace Task1
{
    public class PDF : IPrintable
    {
        public void PrintFile()
        {
            Console.WriteLine("Print PDF");
        }
    }
}
