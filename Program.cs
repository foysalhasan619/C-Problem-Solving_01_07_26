using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowersoftITExamDay2_Ans3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example of Permanent Employee
            PermanentEmployee permEmp = new PermanentEmployee
            {
                Name = "Sazzad Chowdhury",
                JoinDate = new DateTime(2022, 1, 15),
                Basic = 40000,
                Allowance = 15000
            };

            // Example of Hired Employee
            HiredEmployee hiredEmp = new HiredEmployee
            {
                Name = "Jahir Rayhan",
                HireDate = new DateTime(2026, 5, 10),
                PayRate = 250,
                WorkHourPerDay = 8
            };

            // Displaying the outputs
            Console.WriteLine($"Permanent Employee ({permEmp.Name}) Monthly Gross Payable: {permEmp.GetMonthlyGrossPayable()}");
            Console.WriteLine($"Hired Employee ({hiredEmp.Name}) Monthly Gross Payable: {hiredEmp.GetMonthlyGrossPayable()}");
        }
    }
}

