using System;
using System.ComponentModel.DataAnnotations;
using ForumApi.Core.Models;

namespace ForumApi.Post.Models
{
    public class Post
    {
        [Key]
        public Guid Id { get; set; }
        public SimpleUser Author { get; set; }
        public Thread.Models.Thread Thread { get; set; }
        public string Title { get; set; }
        public Content Content { get; set; }
    }
}