using System;
namespace coom{
    class Wont_last{
        static void Main(string[] args){
            int[,] foop = new int[,] {{0,1,3},{2,3,3},{5,5,3}};
           Console.WriteLine(foop.GetUpperBound(0)); 
           Console.WriteLine(foop.GetLowerBound(0)); 
        }
    }
}