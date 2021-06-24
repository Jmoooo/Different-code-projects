using System;

namespace NarwhalCalc
{
    class Program
    {
        static double FeetToTons(double length)
        {
            double weightinton = 0.075;
            double math = length * weightinton;
            return math; 


        }
        static void Main()
        {
            string narwaleask;
            Console.WriteLine("What is the narwhal length in feet? ");
            narwaleask = Console.ReadLine();
            double narwhalelength = Int32.Parse(narwaleask);
            double length =  FeetToTons(narwhalelength);
            Console.WriteLine("Length is " +  length);
            
        }
        
    }
}
