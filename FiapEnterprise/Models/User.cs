using System;
namespace FiapEnterprise.Models
{
    public class User
    {
        public long Id { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? Photo { get; set; }
        public DateTime creationDate { get; set; }
        public List<Employee>? Employees { get; set; }

        public User() { }

        public User(string username, string password, string photo)
        {
            this.UserName = username;
            this.Password = password;
            this.Photo = photo;
            this.creationDate = DateTime.Now;
            this.Employees = new List<Employee>();
        }
    }
}

