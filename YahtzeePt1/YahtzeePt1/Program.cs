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

        //The categories' names
        static String catrgoryAces = "aces";
        static String catrgoryTwos = "twos";
        static String catrgoryThrees = "threes";
        static String catrgoryFours = "fours";
        static String catrgoryFives = "fives";
        static String catrgorySixes = "sixes";

        //The values each category is worth
        static int acesWorth = 1;//Per die
        static int twosWorth = 2;//Per die
        static int threesWorth = 3;//Per die
        static int foursWorth = 4;//Per die
        static int fivesWorth = 5;//Per die
        static int sixesWorth = 6;//Per die

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