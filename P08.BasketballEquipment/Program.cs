using System;

namespace P08.BasketballEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int priceForYear = int.Parse(Console.ReadLine());
            double baskedballShoes = priceForYear - (priceForYear * 0.40);
            double baskedballOutfit = baskedballShoes - (baskedballShoes * 0.20);
            double basketballBall = baskedballOutfit - ( baskedballOutfit - baskedballOutfit * 0.25);
            double baskeballAccessories =  basketballBall - ( basketballBall - basketballBall * 0.20);
            Console.WriteLine(basketballBall + baskedballShoes + baskedballOutfit + baskeballAccessories + priceForYear);



        }
    }
}
