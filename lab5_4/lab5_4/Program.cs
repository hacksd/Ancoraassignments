using System;

namespace lab5_4
{
    class Program
    {
        public struct Mario
        {
            public enum Size
            {
                small,
                large
            }
            public int numOfLives;
            public string currentLevel;
            public Size sizeOfMario;
            public bool canShootFireballs;
            public bool isjumbing;
            public int numbersofCoins;
        }
        static void Main(string[] args)
        {
            Mario supermario = new Mario();
            supermario.numOfLives = 3;
            supermario.currentLevel = "World 1 - 1 ";
            supermario.sizeOfMario = Mario.Size.small;
            supermario.canShootFireballs = false;
            supermario.isjumbing = false;
            supermario.numbersofCoins = 0;

            Console.WriteLine("Mario is running through the level and meets a Gooba. Set Mario to jumping so he can kill it");
            supermario.isjumbing = true;

            Console.WriteLine("Mario squashes the Gooba. Now he needs to land!");
            supermario.isjumbing = false;


            Console.WriteLine("Mario hits a block and finds a 1UP. Increase Mario's life by one.");
            supermario.numOfLives += 1;


            Console.WriteLine("Mario finds a secret Fire Flower and can now shoot fireballs. Change mario!");
            supermario.canShootFireballs = true;


            Console.WriteLine("Mario finds another power up mushroom and gets big. Change Mario");
            supermario.sizeOfMario = Mario.Size.large;


            Console.WriteLine("Mario finds a stash of gold coins. Give Mario 10 coins.");
            supermario.numbersofCoins += 10;


            Console.WriteLine("Mario finshes the level! Change Mario's current level to World 1-2");
            supermario.currentLevel = "World 1-2";


        }
    }
}