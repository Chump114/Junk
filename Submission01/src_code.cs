using System;

namespace Excercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 4; int y = 9;
            x = (y % x != 0) ? y / x : y;
            Console.WriteLine("If int x = 4 and int y = 9 and by logic x = (y % x != 0) ? y / x : y\n" + "Then the value of x is:"+" "+x);
            string poop = Console.ReadLine();
        }
    }
}
