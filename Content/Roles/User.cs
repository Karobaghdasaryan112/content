using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Content.Roles
{
    public class User 
    {
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string ProfilePicture { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Roles { get; set; }
        public string Preferences { get; set; }
        public User(int userID, string firstName, string lastName, DateTime dateOfBirth, string profilePicture, string address, string phoneNumber, string roles, string preferences)
        {
            UserID = userID;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            ProfilePicture = profilePicture;
            Address = address;
            PhoneNumber = phoneNumber;
            Roles = roles;
            Preferences = preferences;
        }
        protected User() { }
    }
}
