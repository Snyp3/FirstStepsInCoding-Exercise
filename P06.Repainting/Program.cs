using System;

namespace P06.Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nylon = int.Parse(Console.ReadLine()); // 1.50
            nylon = nylon + 2;
            double priceNylon = nylon * 1.50;
            double paint = int.Parse(Console.ReadLine()); // 14.50
            paint = paint + paint *0.1;
            double pricePaint = paint * 14.50;
            int thinner = int.Parse(Console.ReadLine()); // 5         nakraq + 0.40 za 1 torbi4ka
            double priceThinner = thinner * 5;
            int time = int.Parse(Console.ReadLine());
            double priceForMaterials = priceNylon + pricePaint + priceThinner + 0.40;
            double priceForWork = (priceForMaterials * 0.3) * time;
            Console.WriteLine(priceForMaterials + priceForWork);

        }
    }
}
