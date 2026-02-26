using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Fundamentals_Library
{
    public interface IEmployee
    {
        string Name { get; }
        decimal Salary { get; set; }
        
        void PrintInfo();
        decimal CalculateBaseBonus();
        string GetReportDetails();

    }
}
