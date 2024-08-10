using Content.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Content.DTO
{
    public class UserContentDTO : User,IContent
    {
        protected string _firstName { get; set; }
        protected string _lastName { get; set; }
        protected DateTime _dateOfBirth { get; set; }
        protected string _profilePicture { get; set; }
        protected string _address { get; set; }
        protected string _phoneNumber { get; set; }
        public UserContentDTO(User user) : base(user.UserID, user.FirstName, user.LastName, user.DateOfBirth, user.ProfilePicture, user.Address, user.PhoneNumber, user.Roles, user.Preferences)
        {
            _firstName = FirstName;
            _lastName = LastName;
            _dateOfBirth = DateOfBirth;
            _profilePicture = ProfilePicture;
            _address = Address;
            _phoneNumber = PhoneNumber;
        }
        public string Tostring()
        {
            return $"FirstName: {_firstName}" +
                $"LastName: {_lastName}" +
                $"DateOfBirth: {_dateOfBirth}" +
                $"ProfilePicture: {_profilePicture}" +
                $"Address: {_address}" +
                $"PhoneNumber: {_phoneNumber}";
        }
    }
}
