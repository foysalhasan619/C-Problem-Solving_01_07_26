using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowersoftITExamDay2_Ans3
{
  public abstract class Employee
{
    public string Name { get; set; }
    
    // Abstract method to get monthly gross payable
    public abstract decimal GetMonthlyGrossPayable();
}

// Permanent Employee Class
public class PermanentEmployee : Employee
{
    public DateTime JoinDate { get; set; }
    public decimal Basic { get; set; }
    public decimal Allowance { get; set; }

    // Gross Payable = Basic + Allowance
    public override decimal GetMonthlyGrossPayable()
    {
        return Basic + Allowance;
    }
}

// Hired Employee Class
public class HiredEmployee : Employee
{
    public DateTime HireDate { get; set; }
    public decimal PayRate { get; set; } 
    public int WorkHourPerDay { get; set; }
    private const int WorkingDaysPerMonth = 22; // Given: 22 Working days per month

    // Gross Payable = Hours * Rate * 22 Days
    public override decimal GetMonthlyGrossPayable()
    {
        return WorkHourPerDay * PayRate * WorkingDaysPerMonth;
    }
}
}
