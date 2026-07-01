using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyPurchasePractise_1_7_26
{
    class Program
    {
        static void Main(string[] args)
        {
            // Populating the collection with given data
            List<DailyPurchase> purchases = new List<DailyPurchase>
        {
            new DailyPurchase { Date = new DateTime(2016, 07, 03), Item = "Pen", UnitPrice = 30, Quantity = 2 },
            new DailyPurchase { Date = new DateTime(2016, 07, 09), Item = "Travel Bag", UnitPrice = 350, Quantity = 1 },
            new DailyPurchase { Date = new DateTime(2016, 07, 13), Item = "Tooth paste", UnitPrice = 80, Quantity = 1 },
            new DailyPurchase { Date = new DateTime(2016, 07, 22), Item = "Pillow Cover", UnitPrice = 120, Quantity = 2 },
            new DailyPurchase { Date = new DateTime(2016, 07, 27), Item = "Coffee", UnitPrice = 210, Quantity = 1 }
        };

            // Defining last month relative to the data (June 2016)
            int targetMonth = 6;
            int targetYear = 2016;

            // 1. Write a LINQ query to show expenses in Last Month
            var lastMonthExpenses = purchases
                .Where(p => p.Date.Month == targetMonth && p.Date.Year == targetYear)
                .ToList();

            Console.WriteLine("1. Expenses in Last Month (June 2016):");
            if (lastMonthExpenses.Count == 0)
            {
                Console.WriteLine("No expenses found in last month.");
            }
            foreach (var p in lastMonthExpenses)
            {
                Console.WriteLine($"- {p.Item}: {p.TotalCost}");
            }

            // 2. Write a LINQ query to show the most expensive product you bought
            var mostExpensive = purchases.OrderByDescending(p => p.UnitPrice).FirstOrDefault();

            Console.WriteLine($"\n2. Most expensive product bought: {mostExpensive?.Item} (Price: {mostExpensive?.UnitPrice})");

            // 3. Create a LINQ query to get total amount in last month
            decimal totalLastMonthAmount = purchases
                .Where(p => p.Date.Month == targetMonth && p.Date.Year == targetYear)
                .Sum(p => p.TotalCost);

            Console.WriteLine($"\n3. Total amount in last month: {totalLastMonthAmount}");
        }
    }
}
