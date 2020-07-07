using System;
using System.ComponentModel.DataAnnotations;

namespace lesson1GitHub
{
    class Program
    {
        static void Main(string[] args)
        {
            // This Program is to calculate when is your Due Date if you are pregnant!

            Console.WriteLine("please Enter the date your period stopped in the form dd/mm/yyyy! ");           // to print on the console 
            var userinput = Console.ReadLine();                                          // varuable to store user input
            DateTime lastperiod;
            DateTime.TryParse(userinput, out lastperiod);                               //test if the user input is correct and transfer the string to datetime format
            DateTime result = lastperiod.AddDays(280);                                        // adding 280 days to the user Date input.
            Console.WriteLine("Your Due Date is :{0: dddd, dd MMMM yyyy}", result);          //printing the result in the console

        }
    }
}