using System;

namespace lab2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lab 2_4");
            int myFirstNumber = 19;
            int mySecondNumber = 244;
            Console.WriteLine("The result is :" + myFirstNumber * mySecondNumber);
            string myText = "Some Text";
            Console.WriteLine(myText + " " + mySecondNumber);
            string moreText = "Goes Here";
            Console.WriteLine(myText + " " + moreText);
            string color1 = "Yellow";
            string color2 = "Red";
            bool isYellow = true;
            bool isGreen = false;
            Console.WriteLine(color1 + " " + isYellow + " " + color2 + " " + isGreen);
            Double NUMBERS;
            NUMBERS = mySecondNumber / myFirstNumber;
            Console.WriteLine(NUMBERS);
            NUMBERS = mySecondNumber / (double)myFirstNumber;
            Console.WriteLine(NUMBERS);
            Console.WriteLine("Breakpoint Here ");
            string textToNumber = "80473";
            int results = 99 * int.Parse(textToNumber);
            Console.WriteLine(results);
            DateTime rightNow = DateTime.Now;
            Console.WriteLine(rightNow);


        }
    }
}