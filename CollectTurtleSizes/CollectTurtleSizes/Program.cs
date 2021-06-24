using System;
using static System.Console;

namespace CollectTurtleSizes
{
    class Program
    {
        static void Main(string[] args)
        {
            double turtleSize;
            double totalSize = 0;
            string inputString;
            double calculate = 0;
            Write("Enter the size of the first turtle: ");
            inputString = ReadLine();
            turtleSize = Convert.ToDouble(inputString);
            while(turtleSize != calculate)
            {
                totalSize += turtleSize;
                Write("Enter the next turtle size, or " + calculate + " to add them up ");
                inputString = ReadLine();
                turtleSize = Convert.ToDouble(inputString);
                
            }

            WriteLine("The total size is " + totalSize);



         

        }
    }
}
