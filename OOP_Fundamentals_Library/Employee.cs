namespace OOP_Fundamentals_Library
{
    public class Employee : Person, IEmployee
    {
        private decimal _salary;
        private string _position;

        public decimal Salary
        {
            get { return _salary; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Salary cannot be negative");
                _salary = value;
            }
        }

        public string Position
        {
            get { return _position; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("The position must be filled");
                _position = value;
            }
        }

        public Employee(string name, int age, decimal salary, string position) : base(name, age)
        {
            Salary = salary;
            Position = position;
        }


        public override void PrintInfo()
        {
            Console.WriteLine($"Employee: {Name}, {Age} years old");
        }

        public virtual void IncreaseSalary(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("The amount of the increase should be positive");
            Salary += amount;
        }
        public virtual decimal CalculateBaseBonus()
        {
            return Salary * 0.1m;
        }

        public virtual string GetReportDetails()
        {
            return $"  Position: {Position}";
        }

    }
}
