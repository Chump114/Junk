using System;


namespace _00Exam
{
    class Program
    {
        static void Main(string[] args)
        {
           string x, y;
            string ch0, ch1, ck;
          
          ;
            Console.WriteLine("Operation?\n(add, subtract, multiply, division, exit)");
            do
            {
                ch0 = Console.ReadLine();
                switch (ch0)
                {
                    
                    case "add":
                        do
                        {

                            ck = "poop";
                            y = "mrkwen";
                            x = "sadkasndlkan";
                            ch1 = "asdsad";
                            Console.WriteLine("Operand0 ?");
                            x = Console.ReadLine();
                            Console.WriteLine("Operand1 ?");
                            y = Console.ReadLine();
                            check(x,y);
                            if (ck == "cool")
                            {
                                
                                Console.WriteLine(x + y + "\nWould you like to calculate again? (yes, no)");
                                ch1 = Console.ReadLine();

                            }
                            else
                            {
                                Console.WriteLine("invalid operands");
                            }

                        }
                        while (ch1 != "no");
                        Console.WriteLine("Operation?\n(add, subtract, multiply, division, exit)");
                        break;
                    case "subtract":
                        do
                        {

                            ck = "poop";
                            y = "mrkwen";
                            x = "sadkasndlkan";
                            ch1 = "asdsad";
                            Console.WriteLine("Operand0 ?");
                            x = Console.ReadLine();
                            Console.WriteLine("Operand1 ?");
                            y = Console.ReadLine();
                            check(x, y);
                            if (ck == "cool")
                            {
                                
                                
                                Console.WriteLine(Convert.ToInt32(x) - Convert.ToInt32(y) + "\nWould you like to calculate again? (yes, no)");
                                ch1 = Console.ReadLine();

                            }
                            else
                            {
                                Console.WriteLine("invalid operands");
                            }

                        }
                        while (ch1 != "no");
                        Console.WriteLine("Operation?\n(add, subtract, multiply, division, exit)");
                        break;
                    case "multiply":
                        do
                        {

                            ck = "poop";
                            y = "mrkwen";
                            x = "sadkasndlkan";
                            ch1 = "asdsad";
                            Console.WriteLine("Operand0 ?");
                            x = Console.ReadLine();
                            Console.WriteLine("Operand1 ?");
                            y = Console.ReadLine();
                            check(x, y);
                            if (ck == "cool")
                            {


                                Console.WriteLine(Convert.ToInt32(x) * Convert.ToInt32(y) + "\nWould you like to calculate again? (yes, no)");
                                ch1 = Console.ReadLine();

                            }
                            else
                            {
                                Console.WriteLine("invalid operands");
                            }

                        }
                        while (ch1 != "no");
                        Console.WriteLine("Operation?\n(add, subtract, multiply, division, exit)");
                        break;
                    case "division":
                        do
                        {

                            ck = "poop";
                            y = "mrkwen";
                            x = "sadkasndlkan";
                            ch1 = "asdsad";
                            Console.WriteLine("Operand0 ?");
                            x = Console.ReadLine();
                            Console.WriteLine("Operand1 ?");
                            y = Console.ReadLine();
                            check(x, y);
                            if (ck == "cool")
                            {


                                Console.WriteLine(Convert.ToInt32(x) / Convert.ToInt32(y) + "\nWould you like to calculate again? (yes, no)");
                                ch1 = Console.ReadLine();

                            }
                            else
                            {
                                Console.WriteLine("invalid operands");
                            }

                        }
                        while (ch1 != "no");
                        Console.WriteLine("Operation?\n(add, subtract, multiply, division, exit)");

                        break;
                    default:
                        if(ch0 != "exit")
                        Console.WriteLine("Sorry, What!");
                            break;
                       
                }
            }
            while (ch0 != "exit");
            void check(string l, string k)
            {
                int z;
                z = 0;
                if(int.TryParse(l, out z) && int.TryParse(k, out z))
                { 
                    ck = "cool";
                }
            }

        }
    }
}
