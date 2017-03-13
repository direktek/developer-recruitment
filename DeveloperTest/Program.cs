using System;
using System.Collections.Generic;
using System.Linq;
using DeveloperTest.Models;

namespace DeveloperTest
{
    internal class Program
    {
        private static IEnumerable<Invoice> _data = new RandomRepository().All();

        private static void Main(string[] args)
        {
            Console.WriteLine("Invoice Manager");

            var userInput = 0;
            do
            {
                userInput = DisplayMenu();

                if (userInput == 1)
                {
                    ListInvoices();
                }

            } while (userInput != 0);
        }

        private static int DisplayMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Type option number then press enter.");

            Console.WriteLine("1. List all invoices");
            
            Console.WriteLine("0. Exit");
            Console.Write(">");
            var result = Console.ReadLine();
            return Convert.ToInt32(result);
        }

        private static void ListInvoices()
        {
            _data.SelectMany(invoice => invoice.LineItems)
                 .ToList()
                 .ForEach(Console.WriteLine);
        }
    }
}
