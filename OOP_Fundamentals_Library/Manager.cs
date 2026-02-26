using System.IO;

namespace OOP_Fundamentals_Library
{
    public class Manager : Employee
    {
        private string _department;
        private List<IEmployee> _team = new List<IEmployee>();
        public IReadOnlyList<IEmployee> Team => _team.AsReadOnly();

        public void AddTOTeam(IEmployee employee)
        {
            if (employee == null)
                throw new ArgumentNullException(nameof(employee));
            if (_team.Contains(employee))
                throw new ArgumentException("This employee is already in the department");
            _team.Add(employee);
        }

        public bool RemoveFromTeam(IEmployee employee)
        {
            if (employee == null)
                throw new ArgumentNullException(nameof(employee));
            return _team.Remove(employee);
        }

        public void ClearTeam()
        {
            _team.Clear();
        }

        public string Department
        {
            get { return _department; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("The department cannot be empty");
                _department = value;
            }
        }

        

        public Manager(string name, int age, decimal salary, string department) : base(name, age, salary, "Manager")
        {
            Department = department;
        }

        

        public override void PrintInfo()
        {
            Console.WriteLine($"Manager: {Name}, {Age} years old, Department: {Department}");
        }

        public void AssTask(IEmployee emp, string task)
        {
            if (emp == null)
                throw new ArgumentNullException(nameof(emp));
            if (string.IsNullOrWhiteSpace(task))
                throw new ArgumentException("The task cannot be empty");
            if (!_team.Contains(emp))
                throw new ArgumentException("This employee is not on your team.");
            Console.WriteLine($"Assigning task '{task}' to {emp.Name}");
        }

        public override decimal CalculateBaseBonus()
        {
            return Salary * 0.2m;
        }

        public override string GetReportDetails()
        {
            return $"  Team: {Team.Count} people";
        }

    }
}
