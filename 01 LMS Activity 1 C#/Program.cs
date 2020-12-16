using System;

namespace LMS00
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            
            {
                const int hehe = 69;
                int check, res;
                int x, ram;
                string sam, buffer, buff;
                Console.WriteLine("Hello! Here's a funny number:"
                        + " "
                        + hehe + "\n" + "hehe Ok!, Let's do some thinking. What if sam = x + y?\n" + "Then what is x then?");
                do
                {
                    
                    
                    sam = Console.ReadLine();
                    if (sam == "chump") {
                        Console.WriteLine(hehe);
                    }
                    else if (int.TryParse(sam, out check))
                    {
                        x = Convert.ToInt32(sam);
                        Console.WriteLine("And y?");
                        ram = Convert.ToInt32(Console.ReadLine());
                        res = x + ram;
                        Console.WriteLine("If that's the case then sam is equal to:" + " " + res);
                        buffer = Console.ReadLine();
                        if(!(buffer == "dsajnd"))
                        {
                            break;
                        }
                        
                    } 
                    else
                    {
                        Console.WriteLine("Real funny buddy. Numbers Only");
                    }
                }
                while (true);
                Console.WriteLine("Im bored!, Let's count to 10\n"+"yes or no?");
                do
                {
                    buffer = Console.ReadLine();
                    if (buffer == "yes")
                    {
                        for (x = 0; x <= 10; x++)
                        {
                            Console.WriteLine(x);
                        }

                        Console.WriteLine("Ok!, Now let's do the opposite.");
                        buffer = Console.ReadLine();
                        for (x=10;x >= 0; x--)
                        {
                            Console.WriteLine(x);
                        }
                        Console.WriteLine("ok that's enough for today, my computing power is getting worn.");
                        buff = Console.ReadLine();
                        if (!(buff == "askldnaslndlkas"))
                        {
                            break;
                        }







                    }
                    else if (buffer == "no")
                    {
                        Console.WriteLine("Aight! Jiyanen");
                        sam = Console.ReadLine();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("What?");
                    }
                }
                while (true);
            }


        }
    }
}
// Marlon Moreno, MAWD 303
