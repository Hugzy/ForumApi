

using System;
using System.ComponentModel.DataAnnotations;
using ForumApi.Core.Models;

namespace ForumApi.Forum.Models
{
    public class Forum
    {
        [Key]
        public Guid Id { get; set; }
        public string Title { get; set; }
        public SimpleUser Author { get; set; }
    }
}