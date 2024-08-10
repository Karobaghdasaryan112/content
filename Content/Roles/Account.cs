using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Content.Roles
{
    public class Account
    {
        public int AccountID { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string AccountType { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime LastLoginDate { get; set; }
        public string Status { get; set; }
        public Account(int accountID, string username, string email, string passwordHash, string accountType, DateTime creationDate, DateTime lastLoginDate, string status)
        {
            AccountID = accountID;
            Username = username;
            Email = email;
            PasswordHash = passwordHash;
            AccountType = accountType;
            CreationDate = creationDate;
            LastLoginDate = lastLoginDate;
            Status = status;
        }
        protected Account() { }
    }
}
