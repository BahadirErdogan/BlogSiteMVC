using BlogSiteMVC.Entities.Enums;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSiteMVC.Entities.Concrete
{
    public class AppUser : IdentityUser
    {
        public AppUser()
        {
            Articles = new HashSet<Article>();
        }

        public string Name { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.Now;
        public DateTime BirthDate { get; set; }
        public Gender Gender { get; set; }
        public string Profession { get; set; }
        public string Photo { get; set; }
        public string ShortBio { get; set; }
        public string Url { get; set; }
        public ICollection<Article> Articles { get; set; }


    }
}
