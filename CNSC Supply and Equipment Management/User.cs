using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNSC_Supply_and_Equipment_Management
{
    public class User
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }
        public DateTime BDate { get; set; }
        public string Gender { get; set; }
        public string Name { get; set; }

        public string UserType { get; set; }

        public User(string id, string email, string password, string address, string contact, DateTime bdate, string gender, string name, string userType)
        {
            Id = id;
            Email = email;
            Password = password;
            Address = address;
            Contact = contact;
            BDate = bdate;
            Gender = gender;
            Name = name;
            UserType = userType;
        }

    
    }
}
