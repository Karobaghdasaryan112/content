using Content.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Content.DTO
{
    public class AccountContentDTO : Account,IContent
    {
        protected string _username { get; set; }
        protected string _email { get; set; }
        protected string _accountType { get; set; }
        protected string _status { get; set; }
        public AccountContentDTO(Account account) : base(account.AccountID, account.Username, account.Email, account.PasswordHash, account.AccountType, account.CreationDate, account.LastLoginDate, account.Status)
        {
            _username = Username;
            _email = Email;
            _accountType = AccountType;
            _status = Status;
        }
        public string Tostring()
        {
            return $"UserName: {_username}" +
                    $"Email:  {_email}" +
                    $"AccountType: {_accountType}" +
                    $"Status:  {_status}";
        }
    }
}
