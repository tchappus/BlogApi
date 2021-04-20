using System;

namespace BlogApi.Models 
{
    public class Post 
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string MarkdownText { get; set; }
        public bool IsPublic { get; set; }
        public bool IsDraft { get; set; }
        public string AttachmentUrls { get; set; }
        public DateTime PostedTimestamp { get; set; }

        public long BlogId { get; set; }
        public long AuthorId { get; set; }
    }
}