using Content.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Content.DTO
{
    public  class ContentDTO : IContent
    {
        private UserContentDTO _userContent;
        private AccountContentDTO _accountContent;
        private ContentDTO(User user)
        {
            _userContent = new UserContentDTO(user);
          
        }
        private ContentDTO(Account account)
        {
            _accountContent = new AccountContentDTO(account);
        }
        private ContentDTO() { }

        public static ContentDTO ResultContent<T>(T role)
        {
            if (typeof(T) == typeof(User))
            {
               User user = role as User;
                return new ContentDTO(user);
            }
            if (typeof(T) == typeof(Account))
            {
                Account Account = role as Account;
                return new ContentDTO(Account);
            }
            throw new Exception("invalid Content");
        }
        public string Tostring()
        {
            if (_userContent != null)
            {
                return _userContent.Tostring();
            }
            if (_accountContent != null)
            {
                return _accountContent.Tostring();
            }
            return "No content available";
        }

    }
}
