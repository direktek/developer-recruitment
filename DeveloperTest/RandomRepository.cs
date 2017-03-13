using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using DeveloperTest.Models;

namespace DeveloperTest
{
    public class RandomRepository : IRepository
    {
        public IEnumerable<Invoice> All()
        {
            var invoices = new List<Invoice>();
            var rnd = new Random();
            var idx = 0;

            while (idx++ < 2)
            {
                var reqDate = DateTime.UtcNow.AddDays(-rnd.Next(10,
                                                                15));
                invoices.Add(new Invoice
                             {
                                 InvoiceNo = string.Format("B2{0}", idx.ToString(CultureInfo.InvariantCulture).PadRight(6, '0')),
                                 BillingCity = _cities[rnd.Next(_cities.Length)],
                                 BillingContact = _contactNames[rnd.Next(_contactNames.Length)],
                                 BillingCounty = _counties[rnd.Next(_counties.Length)],
                                 BillingRoad = _roads[rnd.Next(_roads.Length)],
                                 BillingPostCode = string.Format("{0}-{1}",
                                                            rnd.Next(10000,
                                                                     99999),
                                                            rnd.Next(1000,
                                                                     9999)),
                                 CompanyName = _companyNames[rnd.Next(_companyNames.Length)],
                                 LineItems = GetItems(rnd.Next(1, 10)),
                                 PostedDate = DateTime.UtcNow,
                                 RequisitionDate = reqDate,
                                 Shipping = (decimal) Math.Round(rnd.NextDouble()*35, 2),
                                 ShippingDate = reqDate.AddDays(rnd.Next(3, 5)),
                                 TaxRate = (decimal) Math.Round(rnd.NextDouble(), 2)
                             });
            }

            return invoices;
        }

        private IEnumerable<InvoiceItem> GetItems(int itemCount)
        {
            var items = new List<InvoiceItem>();
            var rnd = new Random();
            var i = 0;

            while (i++ < itemCount)
            {
                var productIdx = rnd.Next(_products.Count());
                items.Add(new InvoiceItem
                          {
                              Discount = (byte) Math.Floor(rnd.NextDouble()*30),
                              Sku = _productSkus[productIdx],
                              LineText = _products[productIdx],
                              Quantity = rnd.Next(1,99),
                              UnitPrice = (decimal) Math.Round(rnd.NextDouble()*600,2),
                              Taxable = Math.Round(rnd.NextDouble(), MidpointRounding.ToEven) > 0
                          });
            }

            return items;
        }
        
        private readonly string[] _contactNames = new[]
                                                  {
                                                      "John Smith",
                                                      "Jane Smith",
                                                      "Curious George",
                                                      "Tony Stark",
                                                      "Mickey Mouse",
                                                      "Bruce Wayne",
                                                      "Clark Kent",
                                                      "Tow Mater"
                                                  };

        private readonly string[] _companyNames = new[]
                                                  {
                                                      "Start Industries",
                                                      "Daily Planet",
                                                      "Mater Towing",
                                                      "Wayne Industries",
                                                      "The Zoo",
                                                      "Buena Vista",
                                                      "ACME Company"
                                                  };

        private readonly string[] _roads = new[]
                                             {
                                                 "8 Century Point",
                                                 "20 Pana Drive",
                                                 "95 Intertel",
                                                 "10 Main St",
                                                 "15 Secret Hideout Dr"
                                             };

        private readonly string[] _cities = new[]
                                            {
                                                "High Wycombe",
                                                "Gerrards Cross",
                                                "London"
                                            };

        private readonly string[] _counties = new[]
                                            {
                                                "Buckinghamshire",
                                                "Berkshire"
                                            };

        private readonly string[] _productSkus = new[]
                                              {
                                                  "PB101",
                                                  "PRA019",
                                                  "PB121",
                                                  "CAN123",
                                                  "TRA863",
                                                  "PAN040",
                                                  "SAM1135"
                                              };

        private readonly string[] _products = new[]
                                              {
                                                  "TV Bracket",
                                                  "Digital Camera",
                                                  "Monitor Stand",
                                                  "Lens",
                                                  "Universal Remote",
                                                  "Coffee Cup",
                                                  "Smart Phone"
                                              };
    }
}