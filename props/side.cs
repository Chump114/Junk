using System;

namespace prop
{

    class fun
    {
        public string apyr;
        
        public string no_no {
            get { return apyr; }
            set { apyr = value; }
        }
     
        public fun()
        {
            Console.WriteLine("Hello! know a funny number?\n");
            do
            {
                int l;
                no_no = Console.ReadLine();
                
                if (int.TryParse(no_no, out l))
                {
                    Console.WriteLine("hehe Ok!, Let's do some thinking. What if sam = x + y?\n" + "Then what is x then?");
                    break;
                }
                else
                {
                    Console.WriteLine("damn bro, you got the whole squad laughing");
                }
            }
            while (true);
          
              
            }

            
        }
    }
    class calculator
    {
    int x,res,ram,check;
    string sam, buffer;

    public calculator()
    {
       
        do
        {


            sam = Console.ReadLine();
            if (sam == "chump")
            {
                Console.WriteLine(666);
            }
            else if (int.TryParse(sam, out check))
            {
                x = Convert.ToInt32(sam);
                Console.WriteLine("And y?");
                ram = Convert.ToInt32(Console.ReadLine());
                res = x + ram;
                Console.WriteLine("If that's the case then sam is equal to:" + " " + res);
                buffer = Console.ReadLine();
                if (!(buffer == "dsajnd"))
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
    }
    }

    class counter
    {
    int x;
    string buffer,buff,sam;
    
    public counter(int r)
    {
        Console.WriteLine("Ok! Let's count to " +r+ "\nyes or no?");
        do
        {
            buffer = Console.ReadLine();
            if (buffer == "yes")
            {
                for (x = 0; x <= r; x++)
                {
                    Console.WriteLine(x);
                }

                Console.WriteLine("Ok!, Now let's do the opposite.");
                buffer = Console.ReadLine();
                for (x = r; x >= 0; x--)
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



