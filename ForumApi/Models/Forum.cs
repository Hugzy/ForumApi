

using System;
using System.ComponentModel.DataAnnotations;

namespace ForumApi.Models
{
    public class Forum
    {
        [Key]
        public Guid Id { get; set; }
        public string Title { get; set; }
        public SimpleUser Author { get; set; }
    }
}