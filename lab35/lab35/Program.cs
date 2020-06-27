using System;

namespace lab3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string blackListWord = "Password";
            bool isSpam = false;
            string message = Console.ReadLine();
            if (message.Contains(blackListWord))
            {
                isSpam = true;
                Console.WriteLine("The message is spam" + isSpam);
            }
            else
            {
                isSpam = false;
                Console.WriteLine("The message is not spam." + isSpam);
            }
        }
    }
}