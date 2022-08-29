using System;
namespace FiapEnterprise.Models
{
    public class EmployeeCLT : Employee
    {
        public double Salary { get; set; }
        public bool PositionTrust { get; set; }

        public EmployeeCLT() { }

        public EmployeeCLT(string name, Gender gender, double salary, bool positionTrust) : base(name, gender)
        {
            this.Salary = salary;
            this.PositionTrust = positionTrust;
        }

        public override double calculateTotalEmployeeCost()
        {
            return this.Salary +
                (calculateVacationRemuneration() * 0.11) +
                (calculateThirteenthSalary() * 0.0833) +
                (calculateFGTS() * 0.08) +
                ((calculateFGTS() / calculateProvisionFineTermination()) * 0.04) +
                (calculatePension() * 0.0793);
        }

        public double calculateVacationRemuneration()
        {
            return 0;
        }

        public double calculateThirteenthSalary()
        {
            return 0;
        }

        public double calculateFGTS()
        {
            return 0;
        }

        public double calculatePension()
        {
            return 0;
        }

        public double calculateProvisionFineTermination()
        {
            return 0;
        }
    }
}

