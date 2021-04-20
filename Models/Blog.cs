using System;
using System.Collections.Generic;

namespace BlogApi.Models 
{
    public class Blog 
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedTimestamp { get; set; }
        public long AuthorId { get; set; }
        public List<Post> Posts { get; set; }
    }
}