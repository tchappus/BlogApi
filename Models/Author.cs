using System;
using System.Collections.Generic;

namespace BlogApi.Models 
{
    public class Author 
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public DateTime JoinTimestamp { get; set; }
        public List<Blog> Blogs { get; set; }
        public List<Post> Posts { get; set; }
    }
}