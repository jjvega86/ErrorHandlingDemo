using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandlingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // EXAMPLE 1

            //List<int> list1 = new List<int>() { 1, 2, 3, 4, 5 };

            //Console.WriteLine(list1[6]);
            //Console.ReadLine();

            // EXAMPLE 2

            //Account bankAccount = new Account("Greg");
            //bankAccount.FindTransaction(12);
            //Console.ReadKey();

            // EXAMPLE 3

            Account bankAccount2 = new Account("Joe");

            try
            {
                Console.WriteLine("Please enter the transaction number you are looking for!");
                double result = bankAccount2.FindTransaction(int.Parse(Console.ReadLine()));
                Console.WriteLine($"Your transaction balance is {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

            Console.ReadLine();




        }
    }
}
