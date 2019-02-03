using System;
using System.Net.Mime;

namespace ForumApi.Models
{
    public class Post
    {
        public Guid Id { get; set; }
        public SimpleUser author { get; set; }
        public Thread thread { get; set; }
        public string Title { get; set; }
        public Content Content { get; set; }
    }
}