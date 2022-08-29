using System;
namespace FiapEnterprise.Models
{
    public abstract class Employee
    {
        public long RegistrationCode { get; set; }
        public string? Name { get; set; }
        public Gender Gender { get; set; }

        public Employee() { }

        public Employee(string name, Gender gender)
        {
            this.RegistrationCode = new Random().Next(0, 1000);
            this.Name = name;
            this.Gender = gender;
        }

        public abstract double calculateTotalEmployeeCost();
    }

    public enum Gender
    {
        MALE, FEMALE, OTHER
    }
}

