using System.Security.Cryptography.X509Certificates;

namespace OOP_Fundamentals_Library
{
    public class PayrollSystem
    {
        public void ProcessSalary(Employee employee)
        {
            decimal oldSalary = employee.Salary;
            decimal bonus = employee.CalculateBaseBonus();
            employee.Salary += bonus;
            Console.WriteLine($"{bonus} awarded to the employee {employee.Name}, Salary = {employee.Salary}");
        }

        public decimal CalculateBonus(IEmployee employee, int years, bool hasCertification)
        {
            decimal bonus = employee.CalculateBaseBonus();

            if (years > 5)
                bonus += 500;

            if (hasCertification)
                bonus += 300;

            return bonus;
        }

    }
}
