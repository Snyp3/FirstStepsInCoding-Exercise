using System;

namespace P05.SuppliesForSchool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pen = int.Parse(Console.ReadLine());  // 5.80 
            double penPrice = pen * 5.80;
            int marker = int.Parse(Console.ReadLine());// 7.20
            double markerPrice = marker * 7.20;
            int cleaning = int.Parse(Console.ReadLine()); // 1.20
            double cleaningPrice = cleaning * 1.20;
            int disscount = int.Parse(Console.ReadLine());
            double price = penPrice + markerPrice + cleaningPrice;
            double disscountFinal = price - (price * disscount / 100);
            Console.WriteLine(disscountFinal);
        }
    }
}
