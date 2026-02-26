namespace OOP_Fundamentals_Library
{
    public class ReportService
    {
        public void GenerateReport(IEmployee emp)
        {
            Console.WriteLine($"Report:");
            emp.PrintInfo();
            Console.WriteLine($"{emp.GetReportDetails()}");
            Console.WriteLine($"  Salary: {emp.Salary}");

        }

    }
}
