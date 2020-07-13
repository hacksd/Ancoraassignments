using System;

namespace lab_2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int numb1; 
            int numb2; 

            Console.WriteLine("Enter a value for the first number:");
            numb1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a value for the second number:");
            numb2 = Convert.ToInt32(Console.ReadLine());
            if (numb1 == 0 && numb2 == 0 )
            {
                Console.WriteLine("please use difrrent numbers because 0/0 is undifiend  ");
            }
            else
            {
                int result = numb1 + numb2;
                Console.WriteLine("The answer is:");
                Console.WriteLine(result);

                result = numb1 - numb2;
                Console.WriteLine("The answer is:");
                Console.WriteLine(result);


                result = numb1 * numb2;
                Console.WriteLine("The answer is:");
                Console.WriteLine(result);

                double results2 = (double)numb1 / (double)numb2;
                double results3 = numb1 % numb2;
                Console.WriteLine("The answer is:");
                Console.WriteLine(results2);
                Console.WriteLine(results3);


            }

        }
    }
}