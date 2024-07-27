using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entity
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
        public string Tz { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        public string? Address { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Password { get; set; }
        public ICollection<Order> Orders { get; set; }
        //public Client()
        //{

        //}
        //public Client(string tz,string firstName, string lastName, string email, string address, string phone, string password)
        //{
        //    this.Tz = tz;
        //    Orders = new List<Order>();
        //    FirstName = firstName;
        //    LastName = lastName;
        //    Email = email;
        //    Address = address;
        //    Phone = phone;
        //    Password = password;
        //}
    }
}