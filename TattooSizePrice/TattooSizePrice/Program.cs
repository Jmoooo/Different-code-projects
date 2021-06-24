using System;

namespace TattooSizePrice
{
    class Program
    {
        static void Main(string[] args)
        {
            string tattooSize;
            int OneInchTattooFee = 50;
            int OnetoThreeInchTattoofee = 100;
            int ThreeInchOrBigger = 200;
            string OneInch = "1";
            string BewteenOneToThree = "2";
            string Three = "3";
            String tattoofee = "Your fee will be $ ";
            Console.WriteLine("Hello, what is your tattoo size? Enter one the size in inches.");
            tattooSize = Console.ReadLine();
            int.Parse(tattooSize);
            if (tattooSize == OneInch )
            {
            Console.WriteLine(tattoofee + OneInchTattooFee);
            }
            if (tattooSize == BewteenOneToThree)
            {
                Console.WriteLine(tattoofee + OnetoThreeInchTattoofee);
            }
            if (tattooSize == Three)
            { 
            Console.WriteLine(tattoofee + ThreeInchOrBigger);
            }
        }
    }
}
