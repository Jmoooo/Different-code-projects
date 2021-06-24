using System;
using static System.Console;

namespace UseSubmarine
{
    class UseSubmarine
    {
        static void Main()
        {
            Submarine sub1 = new Submarine();
            NuclearSubmarine nukeSub = new NuclearSubmarine();
            WriteLine("What is the lenght of the submarine? ");
            sub1.SubLength = Convert.ToInt32(ReadLine());
            WriteLine("What is the max depth that the submarine can go? ");
            sub1.MaxDepth = Convert.ToInt32(ReadLine());
            WriteLine(sub1.GetDisplayMessage());
            WriteLine("What is the lenght of the submarine? ");
            nukeSub.SubLength = Convert.ToInt32(ReadLine());
            WriteLine("What is the max depth that the submarine can go? ");
            nukeSub.MaxDepth = Convert.ToInt32(ReadLine());
            WriteLine("What is the power out out of the reactor?");
            nukeSub.powerOutPut = Convert.ToInt32(ReadLine());
            WriteLine(nukeSub.GetPowerOutPut());

        }
    }
    class Submarine
    {
        public int SubLength { get; set; }
        public int MaxDepth { get; set; }
        public string GetDisplayMessage()
        {
         string displaymessage = "The length of the submarine is " + SubLength + " and the max depth that it can go is " + MaxDepth;
         return displaymessage;
        }
    }
    class NuclearSubmarine : Submarine
    {
        public int powerOutPut { get; set; }
        public string GetPowerOutPut()
        {
            string PowerOutPUt = "The length of the submarine is " + SubLength + " and the max depth that it can go is " + MaxDepth + " the power out put is " + powerOutPut;
            return PowerOutPUt;
        }
    }

}
