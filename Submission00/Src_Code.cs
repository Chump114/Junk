using System;

namespace LabExer2_MRM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("X = Operand 1" + " | " + "Y = Operand 2" +" | "+ "Z = Operand 3\n" + "Operation: Addition\n"+ "Absolute values only"+" "+"(No Decimals)");
            do {
               
                Console.WriteLine("x =");
                string str = Console.ReadLine();
                int num;
                if (str == "exit")
                {
                   
                    if (str == "exit")
                    Console.WriteLine("Jiyanen!");
                    string oof = Console.ReadLine();
                    break;
                }
                else if (int.TryParse(str, out num))
                {
                    int x = Convert.ToInt32(str);
                    Console.WriteLine("y =");
                    int y = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("z =");
                    int z = Convert.ToInt32(Console.ReadLine());
                    int sum = x + y + z;
                    Console.WriteLine("Result; (" + sum + ")");
                    
                }
                else
                {
                    Console.WriteLine("Uhh.... What?" + " " + "(Note: type 'exit' to quit the program)");
                }
            }
            while (true);
            // original logic
            
            /*  
            do {
                Console.WriteLine("x =");
                string str = Console.ReadLine();
                if  (str == "exit")
                {
                    Console.WriteLine("Program is Asleep");
                    break;
                }
                else
                {
                    int x = Convert.ToInt32(str);
                    Console.WriteLine("y =");
                    int y = Convert.ToInt32(Console.ReadLine());
                    int sum = x + y;
                    Console.WriteLine("Result; (" + sum + ")");
                }
                    }
            while (true);
          */
        }
    }
}

/* Student note:
 * hehehe tbh mam i kinda went ahead and looked up a way on how to identify an int and found out an article in
 * stack overflow, i just remembered a specific method in c++ that does that exact thing and went ahead and looked for a 
 * c# equivalent.
 - Marlon Moreno, MAWD 303
 */