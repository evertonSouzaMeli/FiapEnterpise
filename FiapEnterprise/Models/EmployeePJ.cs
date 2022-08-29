using System;
namespace FiapEnterprise.Models
{
    public class EmployeePJ : Employee
    {
        public decimal Wage { get; set; }
        public decimal TotalHours { get; set; }
        public string? Cnpj { get; set; }

        public EmployeePJ() { }

        public EmployeePJ(string name, Gender gender, decimal wage, string cnpj ) : base(name, gender)
        {
            this.Name = name;
            this.Gender = gender;
            this.Wage = wage;
            this.Cnpj = cnpj;
        }

        public override double calculateTotalEmployeeCost()
        {
            throw new NotImplementedException();
        }
    }
}

