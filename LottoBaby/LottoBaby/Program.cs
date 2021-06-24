using System;
using static System.Console;


namespace LottoBaby
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lottoNumbers = { 7, 15, 21, 33, 62, 23 };
            int userLottoNum;
            bool isValidItem = false;
            Write("Please enter one of the numbers off your ticket: ");
            userLottoNum = Convert.ToInt32(ReadLine());
            for(int x=0; x < lottoNumbers.Length; ++x)
            {
                if (userLottoNum == lottoNumbers[x])
                {
                    isValidItem = true;
                    x = lottoNumbers.Length;
                }
            }
            if (isValidItem)

                WriteLine("Your a winner and the winning number is " + userLottoNum );
            else
                WriteLine("Sorry you didn't win, better luck next time.");//me being nice :D
            
        }

    }
}
