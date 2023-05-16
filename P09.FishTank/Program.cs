using System;

namespace P09.FishTank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine()); 
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());
            int volumeFishThank = length * width * height;
            double volumeInLitre = volumeFishThank * 0.001;
            double occupiedSpace = percent = percent * 0.01;
            Console.WriteLine(volumeInLitre * ( 1 - occupiedSpace));
        }
    }
}
