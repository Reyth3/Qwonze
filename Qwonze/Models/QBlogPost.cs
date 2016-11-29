using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Qwonze.Models
{
    public class QBlogPost
    {
        public QBlogPost() { }
        public QBlogPost(string title, string text, string category)
        {
            Title = title;
            Text = text;
            Category = category;
            PostingDate = DateTime.UtcNow;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime PostingDate { get; set; }
        public string PostedOn { get { return "Posted On: " + PostingDate.ToShortDateString(); } }
        public string Category { get; set; }
    }
}