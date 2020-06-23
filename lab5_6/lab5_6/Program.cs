using System;

namespace lab5_6
{
    class Program
    {
        struct customer
        {
            public enum mType
            {
                premum,
                not_premum

            }
            public int cust_id;
            public string firstname;
            public string lastname;
            public int age;
            public mType membershiptype;
        }
        static void Main(string[] args)
        {

            customer Customer = new customer();
            Customer.cust_id = 1;
            Customer.firstname = "John";
            Customer.lastname = "Adam";
            Customer.age = 16;
            Customer.membershiptype = customer.mType.not_premum;

            customer Customer1 = new customer();
            Customer1.cust_id = 2;
            Customer1.firstname = "Susan";
            Customer1.lastname = "Ronald";
            Customer1.age = 21;
            Customer1.membershiptype = customer.mType.not_premum;

            customer Customer2 = new customer();
            Customer2.cust_id = 3;
            Customer2.firstname = "Donald";
            Customer2.lastname = "King";
            Customer2.age = 35;
            Customer2.membershiptype = customer.mType.premum;
            customer[] allCustomers = { Customer, Customer1, Customer2 };
            for (int i = 0; i < allCustomers.Length; i++)
            {
                if (allCustomers[i].age < 21)
                {
                    Console.WriteLine("Hello! " + allCustomers[i].firstname + " " + allCustomers[i].lastname);
                    Console.WriteLine("we are unable to complete your order because you are under 21 yo");
                }
                else if (allCustomers[i].age >= 21 && allCustomers[i].membershiptype == customer.mType.premum)
                {
                    Console.WriteLine("Hello! " + allCustomers[i].firstname + " " + allCustomers[i].lastname);
                    Console.WriteLine("Thank you for being a premum member. your order is complete with one houre shipping");
                }
                else if (allCustomers[i].age >= 21 && allCustomers[i].membershiptype == customer.mType.not_premum)
                {
                    Console.WriteLine("Hello! " + allCustomers[i].firstname + " " + allCustomers[i].lastname);
                    Console.WriteLine("Thank you!. your order is complete with 7 days shipping");
                }
                else
                {
                    Console.WriteLine("please login to order");
                    
                }

            }
            

        }
    }
}
