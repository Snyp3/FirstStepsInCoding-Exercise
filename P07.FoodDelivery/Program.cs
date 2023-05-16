using System;

namespace P07.FoodDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chicken = int.Parse(Console.ReadLine());
            double chickenPrice = chicken * 10.35;
            int fish = int.Parse(Console.ReadLine());
            double fishPrice = fish * 12.40;
            int vegeterian = int.Parse(Console.ReadLine());
            double vegeterianPrice = vegeterian * 8.15;
            double totalPrice = chickenPrice + fishPrice + vegeterianPrice;
            double dessert = totalPrice - ( totalPrice - totalPrice * 0.20);
            Console.WriteLine(totalPrice + dessert + 2.50);


        }
    }
}
