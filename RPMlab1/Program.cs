using OOP_Fundamentals_Library;
internal class Program
{
    static void Main(string[] args)
    {
        var customer = new Customer ("John", 30);

        var employee = new Employee("Alice", 25, 50000, "Developer");

        var manager = new Manager("Bob", 40, 80000, "IT");

        manager.AddTOTeam(employee);
        employee.IncreaseSalary(5000);

        Console.WriteLine("info abot people");
        customer.PrintInfo();
        employee.PrintInfo();
        manager.PrintInfo();
        Console.WriteLine();

        Console.WriteLine("managers tool");
        manager.AssTask(employee, " add a report");
        Console.WriteLine();

        Console.WriteLine("Sallary count");
        var payroll = new PayrollSystem();
        payroll.ProcessSalary(employee);
        payroll.ProcessSalary(manager);
        Console.WriteLine($"Employee bonus: {payroll.CalculateBonus(employee, 6, true)}");
        Console.WriteLine($"Manager bonus: {payroll.CalculateBonus(manager, 3, false)}");
        Console.WriteLine();

        Console.WriteLine("Reports");
        var reportService = new ReportService();
        reportService.GenerateReport(employee);
        reportService.GenerateReport(manager);

        
    }
}