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
    public class ContentService : IContentService
    {
        ContentDTO IContentService.GetContent<T>(T role) 
        {
            if (typeof(T) == typeof(User))
            {
                return  ContentDTO.ResultContent(role);
            }
            if (typeof(T) == typeof(Account))
            {
                return  ContentDTO.ResultContent(role);
            }
            throw new Exception("Invalid Role");
        }
    }
}
