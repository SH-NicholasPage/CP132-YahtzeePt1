/*
* Name: [YOUR NAME HERE]
* South Hills Username: [YOUR SOUTH HILLS USERNAME HERE]
*/
using System;

namespace YahtzeePt1
{
    class Program
    {
        //Your dice (all values are 0 initially)
        static int die1, die2, die3, die4, die5, die6;

        //The categories
        static String catrgoryAces = "aces";
        static String catrgoryTwos = "twos";
        static String catrgoryThrees = "threes";
        static String catrgoryFours = "fours";
        static String catrgoryFives = "fives";
        static String catrgorySixes = "sixes";

        //The values categories are worth
        static int acesWorth = 1;
        static int twosWorth = 2;
        static int threesWorth = 3;
        static int foursWorth = 4;
        static int fivesWorth = 5;
        static int sixesWorth = 6;

        //Score
        static int score = 0;

        static void Main()
        {
            Console.Title = "My Yahtzee game!";

            //TODO: Your code here

            Console.WriteLine("Game over! Your final score was " + score);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}