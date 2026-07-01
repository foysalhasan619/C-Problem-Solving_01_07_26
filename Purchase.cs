using System;
using System.Collections.Generic;
using System.Linq;

public class DailyPurchase
{
    public DateTime Date { get; set; }
    public string Item { get; set; }
    public decimal UnitPrice { get; set; }
    public int Quantity { get; set; }

    // Property to calculate total cost (Price * Quantity)
    public decimal TotalCost => UnitPrice * Quantity;
}
