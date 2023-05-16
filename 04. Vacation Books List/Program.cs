using System;
using System.Runtime.InteropServices;

namespace _04._Vacation_Books_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int page = int.Parse(Console.ReadLine());
            int rate = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int hours = (page / rate);
            int dh = (hours / days);
            Console.WriteLine(dh);
        }
    }
}
