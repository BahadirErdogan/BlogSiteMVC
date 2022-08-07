using BlogSiteMVC.Entities.Abstract;
using BlogSiteMVC.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSiteMVC.Entities.Concrete
{
    public class Article : BaseEntity
    {
        public Article()
        {
            Topics = new HashSet<Topic>();
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public string Picture { get; set; }
        public int? ReadingTime { get; set; }
        public int? View { get; set; }
        public ArticleType ArticleType { get; set; }
        public AppUser AppUser { get; set; }
        public ICollection<Topic> Topics { get; set; }

    }
}
