using System;
using System.Collections.Generic;

namespace lab5_2
{
    class Program
    {
        public enum WeekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday

        }
        static void Main(string[] args)
        {
            //creating a list
            List<string> TaskList = new List<string>();

            foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)) )
            {
                Console.WriteLine("Enter a new task for " + day);
                string tasks = day + " : " + Console.ReadLine();
                TaskList.Add(tasks);

            }
            // the output foreach
            foreach (string listitem in TaskList)
            {
                Console.WriteLine(listitem);
            }

        }
    }
}
