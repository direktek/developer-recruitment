using System;
using System.Linq;

namespace DeveloperTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var data = new Repo().All();

            // Here is an initial starting point. This example does not include all required fields for output.
            data.SelectMany(invoice => invoice.LineItems)
                .ToList()
                .ForEach(Console.WriteLine);

            Console.ReadLine();
        }
    }
}
