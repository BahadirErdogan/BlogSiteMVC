using BlogSiteMVC.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSiteMVC.Entities.Concrete
{
    public class Topic : BaseEntity
    {
        public Topic()
        {
            Articles = new HashSet<Article>();
        }
        public string Name { get; set; }
        public ICollection<Article> Articles { get; set; }
    }
}
