using Content.DTO;
using Content.Roles;
using Content.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Content
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User(1, "Karo", "Baghdasaryan",  new DateTime(2002,8,21), "MyPicture", "Boryan 4/1", "055175566", "some Role", "some");
            IContentService content = new ContentService();
            IContent UserContentDTO = content.GetContent(user);
            Account account = new Account(1, "Karo123", "KaroBaghdasaryan@gmail.com", "some", "standart", DateTime.Now, DateTime.Now,"checked");
            IContent AccountContentDTO = content.GetContent(account);
            Console.WriteLine(AccountContentDTO.Tostring());
            Console.WriteLine(UserContentDTO.Tostring());
            Console.ReadLine(); 
        }
    }
}
