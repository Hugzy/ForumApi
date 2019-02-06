using System;
using System.ComponentModel.DataAnnotations;

namespace ForumApi.Models
{
    public class Post
    {
        [Key]
        public Guid Id { get; set; }
        public SimpleUser author { get; set; }
        public Thread thread { get; set; }
        public string Title { get; set; }
        public Content Content { get; set; }
    }
}